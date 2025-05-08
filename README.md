❗This is a fork of  <a href="https://github.com/winauth/winauth">WinAuth</a> (includes updates from <a href="https://github.com/Florastamine/winauth">Florastamine 2020-09-01</a> repo) and also added some essential features:

- Winauth is now standalone `.exe` file (produced by `Costura.Fody`)._[to make it fully portable, copy `WinAuth.xml` from `%appdata%\WinAuth` aside to `WinAuth.exe`]_
- Search-box to quickly filter the desired sites from list.
- Option to **drag & drop** QR-image onto the Add-Authenticator window.
- Option to **auto-copy** the one-time code if the searched result is single.
- Option to **auto-close app**  (to save an extra click) when you copy the code..
- Fixed "Auto-Update" interval option being erased on next re-open.

(There seems to be an intermittent issue - WinAuth takes a while to open on startup if there are dozens of items added).
