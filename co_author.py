from subprocess import run, CalledProcessError
from sys import exit
import re
# Provide your own dict, format described below
from authors import authors

author1 = "Co-authored-by: [Bowen Zhang] <zhangb82@mcmaster.ca>\n"
author2 = "Co-authored-by: [Jiacheng Wu] <wuj187@mcmaster.ca>\n"
author3 = "Co-authored-by: [Yichen Jiang] <jiany34@mcmaster.ca>\n"
author4 = "Co-authored-by: [Junhong Chen] <chenj297@mcmaster.ca>\n"
author5 = "Co-authored-by: [Tingyu Shi] <shit19@mcmaster.ca>"
co_authors = author1 + author2 + author3 + author4 + author5

def run_git_commit(message: str):
    message = message + "\n\n" + co_authors
    command = ["git", "commit", "-m", message]
    run(command)

'''
def build_commit_message(message: str, comma_separated_aliases: str) -> str:
    """Formats the commit message with full co-author data"""
    co_authors = get_full_co_author_data_from(comma_separated_aliases, authors)
    return f"{message}\n\n{co_authors}"
'''

if __name__ == "__main__":
    try:
        message = input('Enter your commit message: \n')
        run_git_commit(message)
        exit(0)

    except IndexError:
        print("INVALID PARAMETERS")
        exit(1)
    except KeyError:
        print("INVALID ALIAS")
        exit(1)
    except CalledProcessError:
        print("GIT COMMAND FAILED")
        exit(1)
    except KeyboardInterrupt:
        exit(1)