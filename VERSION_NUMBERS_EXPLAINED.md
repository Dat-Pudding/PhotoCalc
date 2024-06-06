# How do the version numbers work
## Structure of a version number
Each version number is made up from a prefix that indicates the overall development stage (as soon as the full release is reached the prefix is left out), a dash connecting the prefix with the actual version number that comes in the format of three numerals divided by dots and as whole prepended with the letter "v".
This structure is appended by the build and patch indicators in the form of a letter followed by a numeral. If no patch has been applied the numeral is left out.
In this form the version number `v1.0.0r` poses the first full-release version with everything from `pre-alpha-v0.0.1` to `beta-v9.9r9` being considered "Early Access" builds.

### Suffix
The version number has either "d", "t" or "r" appended.
#### Suffix Key:
- "d" indicates that it's a developement build to which a debugger and profiler can be attached
- "t" indicates a test build, the included features may and likely will contain bugs, glitches and other issues
- "r" indicates a release build, meaning that all known bugs and glitches of that version should be fixed
- sometimes a numeral might be appended to the letter, this counts the number of patches applied within the version level and type