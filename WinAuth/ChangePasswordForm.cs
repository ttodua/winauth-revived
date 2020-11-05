/*
 * Copyright (C) 2013 Colin Mackie.
 * This software is distributed under the terms of the GNU General Public License.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
#if NETFX_4
using System.Threading.Tasks;
#endif
using System.Windows.Forms;
using MetroFramework.Controls;
using WinAuth.Resources;

namespace WinAuth
{
	/// <summary>
	/// Form for setting the password and encryption for the current authenticators
	/// </summary>
	public partial class ChangePasswordForm : WinAuth.ResourceForm
	{
		/// <summary>
		/// Used to show a filled password box
		/// </summary>
		private const string EXISTING_PASSWORD = "******";

		/// <summary>
		/// Create the form
		/// </summary>
		public ChangePasswordForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Current and new password type
		/// </summary>
		public Authenticator.PasswordTypes PasswordType { get; set; }

		/// <summary>
		/// Current and new password
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// If have a current password
		/// </summary>
		public bool HasPassword { get; set; }

		/// <summary>
		/// List of seedwords
		/// </summary>
		private List<string> _seedWords = new List<string>();

		/// <summary>
		/// Load the form and pretick checkboxes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangePasswordForm_Load(object sender, EventArgs e)
		{
			if ((PasswordType & Authenticator.PasswordTypes.Machine) != 0 || (PasswordType & Authenticator.PasswordTypes.User) != 0)
			{
				machineCheckbox.Checked = true;
			}
			if ((PasswordType & Authenticator.PasswordTypes.User) != 0)
			{
				userCheckbox.Checked = true;
			}
			userCheckbox.Enabled = machineCheckbox.Checked;

			if ((PasswordType & Authenticator.PasswordTypes.Explicit) != 0)
			{
				passwordCheckbox.Checked = true;
				if (HasPassword == true)
				{
					passwordField.Text = EXISTING_PASSWORD;
					verifyField.Text = EXISTING_PASSWORD;
				}
			}
		}

		/// <summary>
		/// Form has been shown
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangePasswordForm_Shown(object sender, EventArgs e)
		{
			// Buf in MetroFrame where focus is not set correcty during Load, so we do it here
			if (passwordField.Enabled == true)
			{
				passwordField.Focus();
			}
		}

		/// <summary>
		/// Machine encryption is ticked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void machineCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (machineCheckbox.Checked == false)
			{
				userCheckbox.Checked = false;
			}
			userCheckbox.Enabled = machineCheckbox.Checked;
		}

		/// <summary>
		/// Password encrpytion is ticked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			passwordField.Enabled = (passwordCheckbox.Checked);
			verifyField.Enabled = (passwordCheckbox.Checked);
			if (passwordCheckbox.Checked == true)
			{
				passwordField.Focus();
			}
		}

		/// <summary>
		/// OK button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void okButton_Click(object sender, EventArgs e)
		{
			// check password is set if requried
			if (passwordCheckbox.Checked == true && passwordField.Text.Trim().Length == 0)
			{
				WinAuthForm.ErrorDialog(this, strings.EnterPassword);
				this.DialogResult = System.Windows.Forms.DialogResult.None;
				return;
			}
			if (passwordCheckbox.Checked == true && string.Compare(passwordField.Text.Trim(), verifyField.Text.Trim()) != 0)
			{
				WinAuthForm.ErrorDialog(this, strings.PasswordsDontMatch);
				this.DialogResult = System.Windows.Forms.DialogResult.None;
				return;
			}

			// set the valid password type property
			PasswordType = Authenticator.PasswordTypes.None;
			Password = null;
			if (userCheckbox.Checked == true)
			{
				PasswordType |= Authenticator.PasswordTypes.User;
			}
			else if (machineCheckbox.Checked == true)
			{
				PasswordType |= Authenticator.PasswordTypes.Machine;
			}
			if (passwordCheckbox.Checked == true)
			{
				PasswordType |= Authenticator.PasswordTypes.Explicit;
				if (this.passwordField.Text != EXISTING_PASSWORD)
				{
					Password = this.passwordField.Text.Trim();
				}
			}
		}

		/// <summary>
		/// Get a new random seed
		/// </summary>
		/// <param name="wordCount">number of words in seed</param>
		/// <returns></returns>
		private string GetSeed(int wordCount)
		{
			if (_seedWords.Count == 0)
			{
				using (var s = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("WinAuth.Resources.SeedWords.txt")))
				{
					string line;
					while ((line = s.ReadLine()) != null)
					{
						if (line.Length != 0)
						{
							_seedWords.Add(line);
						}
					}
				}
			}

			List<string> words = new List<string>();
			RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
			byte[] buffer = new byte[4];
			for (var i = 0; i < wordCount; i++)
			{
				random.GetBytes(buffer);
				int pos = (int)(BitConverter.ToUInt32(buffer, 0) % (uint)_seedWords.Count());

				// check for duplicates
				var word = _seedWords[pos].ToLower();
				if (words.IndexOf(word) != -1)
				{
					i--;
					continue;
				}
				words.Add(word);
			}

			return string.Join(" ", words.ToArray());
		}
	}

}
