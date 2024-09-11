namespace OOP.CatacombsOfClass
{
    public static class TheLockedDoor
    {
        public static void Run()
        {
            Console.WriteLine("To create a new door, please enter a passcode:");
            if (int.TryParse(Console.ReadLine(), out var passcode))
            {
                var door = new Door(passcode);
                while (true)
                {
                    Console.WriteLine($"You are standing in front of a {door.GetState()} door. What would you like to do?");
                    Console.WriteLine("1. Open the door");
                    Console.WriteLine("2. Close the door");
                    Console.WriteLine("3. Lock the door");
                    Console.WriteLine("4. Unlock the door");
                    Console.WriteLine("5. Change the passcode");
                    Console.WriteLine("6. Exit");

                    var choice = Console.ReadLine();
                    if (choice == "6") break;

                    HandleUserChoice(choice, door);
                }
            }
            else
            {
                Console.WriteLine("Invalid passcode. Please enter a number.");
            }
        }

        private static void HandleUserChoice(string choice, Door door)
        {
            switch (choice)
            {
                case "1":
                    if (door.GetState() == Door.DoorState.Locked)
                    {
                        Console.WriteLine("The door is locked. Please unlock it first.");
                    }
                    else if (door.GetState() == Door.DoorState.Opened)
                    {
                        Console.WriteLine("The door is already opened.");
                    }
                    else
                    {
                        door.Open();
                    }
                    break;
                case "2":
                    if (door.GetState() == Door.DoorState.Closed || door.GetState() == Door.DoorState.Locked)
                    {
                        Console.WriteLine("The door is already closed.");
                    }
                    else
                    {
                        door.Close();
                    }
                    break;
                case "3":
                    HandleLockUnlock(door, true);
                    break;
                case "4":
                    HandleLockUnlock(door, false);
                    break;
                case "5":
                    ChangeDoorPasscode(door);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        private static void HandleLockUnlock(Door door, bool isLocking)
        {
            if (isLocking)
            {
                if (door.GetState() == Door.DoorState.Opened)
                {
                    Console.WriteLine("The door is opened. Please close it first.");
                }
                else if (door.GetState() == Door.DoorState.Locked)
                {
                    Console.WriteLine("The door is already locked.");
                }
                else
                {
                    Console.WriteLine("Please enter the passcode to lock the door:");
                    if (int.TryParse(Console.ReadLine(), out var input))
                    {
                        door.Lock(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid passcode. Please enter a number.");
                    }
                }
            }
            else
            {
                if (door.GetState() != Door.DoorState.Locked)
                {
                    Console.WriteLine("The door is not locked.");
                }
                else
                {
                    Console.WriteLine("Please enter the passcode to unlock the door:");
                    if (int.TryParse(Console.ReadLine(), out var input))
                    {
                        door.Unlock(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid passcode. Please enter a number.");
                    }
                }
            }
        }

        private static void ChangeDoorPasscode(Door door)
        {
            Console.WriteLine("Please enter the old passcode:");
            if (int.TryParse(Console.ReadLine(), out var oldPasscode))
            {
                Console.WriteLine("Please enter the new passcode:");
                if (int.TryParse(Console.ReadLine(), out var newPasscode))
                {
                    door.ChangePasscode(oldPasscode, newPasscode);
                }
                else
                {
                    Console.WriteLine("Invalid passcode. Please enter a number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid passcode. Please enter a number.");
            }
        }

        public class Door(int passcode)
        {
            private DoorState _state = DoorState.Closed;

            public enum DoorState
            {
                Opened,
                Closed,
                Locked,
                Unlocked
            }

            public void Open()
            {
                if (_state == DoorState.Closed)
                {
                    _state = DoorState.Opened;
                }
            }

            public void Close()
            {
                if (_state == DoorState.Opened)
                {
                    _state = DoorState.Closed;
                }
            }

            public void Lock(int passcode1)
            {
                if (passcode1 == passcode && (_state == DoorState.Closed || _state == DoorState.Unlocked))
                {
                    _state = DoorState.Locked;
                }
                else
                {
                    Console.WriteLine("Invalid passcode. Please enter the correct passcode.");
                }
            }

            public void Unlock(int passcode1)
            {
                if (passcode1 == passcode && _state == DoorState.Locked)
                {
                    _state = DoorState.Unlocked;
                }
                else
                {
                    Console.WriteLine("Invalid passcode. Please enter the correct passcode.");
                }
            }

            public DoorState GetState()
            {
                return _state;
            }

            public void ChangePasscode(int oldPasscode, int newPasscode)
            {
                if (oldPasscode == passcode)
                {
                    passcode = newPasscode;
                }
                else
                {
                    Console.WriteLine("Invalid old passcode. Please enter the correct passcode.");
                }
            }
        }
    }
}