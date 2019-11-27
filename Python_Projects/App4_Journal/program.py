import journal


def main():
    print_header()
    run_event_loop()


def print_header():
    print('----------------------------')
    print('        JOURNAL APP')
    print('----------------------------')


def run_event_loop():
    cmd = 'EMPTY'
    journal_name = 'default'
    journal_data = journal.load(journal_name)

    while cmd != "e" and cmd:

        cmd = input('What would you like to do with your journal? [A]dd, [L]ist, [E]xit ')
        cmd = cmd.lower().strip()

        if cmd == "a":
            add_entry(journal_data)
        elif cmd == "l":
            list_entry(journal_data)
        elif cmd != "e" and cmd:
            print("Sorry, I don't understand '{}'".format(cmd))

    print('Goodbye!')

    journal.save(journal_name, journal_data)


def add_entry(data):
    entry = input('Please add your journal entry: ')
    journal.add_entry(data, entry)


def list_entry(data):
    data = reversed(data)
    for (idx, item) in enumerate(data):
        print('{}: {}'.format(idx, item))


if __name__ == '__main__':
    main()
