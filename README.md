❗   ❗   ❗       
(Read the <a href="https://github.com/winauth/winauth">original WinAuth's README</a>)

Unfortunately, original WinAuth's development has been archived, without leaving a way to contact author & suggest updates. I've forked it (on top of <a href="https://github.com/Florastamine/winauth">Florastamine 2020-09-01</a> update) and added some essential features:

- Winauth is now standalone `.exe` file is being (produced by `Costura.Fody`)._[to make it portable, copy WinAuth.xml from `%appdata%\WinAuth` aside to `WinAuth.exe`]_
- Search-box to quickly filter the desired sites from list.
- Option to **drag & drop** QR-image onto the Add-Authenticator window.
- Option to **auto-copy** the one-time code if the searched result is single.
- Option to **auto-close app**  (to save an extra click) when you copy the code..
- Fixed "Auto-Update" interval option being erased on next re-open.

(One issue still persists which we couldn't fix - when having tons of sites, WinAuth takes a while to open on startup).
