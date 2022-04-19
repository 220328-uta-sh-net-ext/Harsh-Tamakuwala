# Assignment-2

## History of linux and shell 

Shells—or command-line interpreters—have a long history, but this discussion begins with the first UNIX® shell. Ken Thompson (of Bell Labs) developed the first shell for UNIX called the V6 shell in 1971. Similar to its predecessor in Multics, this shell (/bin/sh) was an independent user program that executed outside of the kernel. Concepts like globbing (pattern matching for parameter expansion, such as *.txt) were implemented in a separate utility called glob, as was the if command to evaluate conditional expressions. This separation kept the shell small, at under 900 lines of C source (see Related topics for a link to the original source).

The shell introduced a compact syntax for redirection (< > and >>) and piping (| or ^) that has survived into modern shells. You can also find support for invoking sequential commands (with ;) and asynchronous commands (with &).

What the Thompson shell lacked was the ability to script. Its sole purpose was as an interactive shell (command interpreter) to invoke commands and view results.

## The Shell Variables and Environment

*Holds the version of this instance of bash.* - **echo $BASH_VERSION**
*The name of the your computer.* - **echo $HOSTNAME**
*The search path for the cd command.* - **echo $CDPATH**
*The name of the file in which command history is saved.* - **echo $HISTFILE**
*The maximum number of lines contained in the history file.* - **echo $HISTFILESIZE**
*The number of commands to remember in the command history. The default value is 500.* - **echo $HISTSIZE**
*The home directory of the current user.* - **echo $HOME**
*The Internal Field Separator that is used for word splitting after expansion and to split lines into words with the read builtin command. The default value is <space><tab><newline>.* - **echo $IFS**
*Used to determine the locale category for any category not specifically selected with a variable starting with LC_.* - **echo $LANG**
*The search path for commands. It is a colon-separated list of directories in which the shell looks for commands.* - **echo $PATH**
*Your prompt settings.* -**echo $PS1**
*The default timeout for the read builtin command. Also in an interactive shell, the value is interpreted as the number of seconds to wait for input after issuing the command. If not input provided it will logout user.* - **echo $TMOUT**
*Your login terminal type.* - **echo $TERM
export TERM=vt100**
*Set path to login shell.* - **echo $SHELL**
*Set X display name* - **echo $DISPLAY _export DISPLAY_=:0.1**
~~EDITOR~~ *Set name of default text editor.* - ***export EDITOR=/usr/bin/vim***


![This is an image](https://myoctocat.com/assets/images/base-octocat.svg)