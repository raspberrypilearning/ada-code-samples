/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples
{
    class QueuesExample
    {
        public const int MaxSize = 4;

        // The Main method is the entry point for all C# programs
        public static void Main() {
            Console.WriteLine("### Queue ###");

            // Initialise the queue and pointers
            string[] queue = new string[MaxSize];
            int front = 0;
            int rear = -1;

            // Insert test data into the queue
            rear = Enqueue(queue, rear, "Julie");
            OutputQueue(queue, front, rear);
            
            rear = Enqueue(queue, rear, "Rey");
            OutputQueue(queue, front, rear);
            
            rear = Enqueue(queue, rear, "Habib");
            OutputQueue(queue, front, rear);
            
            rear = Enqueue(queue, rear, "Sabrina");
            OutputQueue(queue, front, rear);

            // Trying to enqueue - should say queue is full
            rear = Enqueue(queue, rear, "Mina");
            OutputQueue(queue, front, rear);

            // Dequeue all of the items
            for (int i = 0; i < queue.Length; i++) {
                // Tuple is used to store multiple return values
                Tuple<string, int> dequeuedValues; // data, front

                dequeuedValues = Dequeue(queue, front, rear);
                front = dequeuedValues.Item2;
                Console.WriteLine($"\nDequeued {dequeuedValues.Item1}");
            }

            // This shouldn't enqueue Eirini since there is no implementation for
            // writing over any dequeued elements
            rear = Enqueue(queue, rear, "Eirini");
            Console.WriteLine($"Rear: {rear}");
        }

        // Check if the queue is empty
        public static bool IsEmpty(int front, int rear) {
            if (front > rear)
                return true;
            else
                return false;
        }

        // Check if the queue is full
        public static bool IsFull(int rear) {
            if (rear + 1 == MaxSize)
                return true;
            else
                return false; 
        }

        // Enqueue an item
        public static int Enqueue(string[] queue, int rear, string data) {
            if (IsFull(rear)) {
                Console.WriteLine($"\nQueue is full - {data} not added");
            }
            else {
                rear = rear + 1;
                queue[rear] = data;
            }
            return rear;
        }

        // Dequeue an item
        public static Tuple<string, int> Dequeue(string[] queue, int front, int rear) {
            string dequeuedItem;

            if (IsEmpty(front, rear)) {
                Console.WriteLine("\nQueue is empty - nothing to dequeue");
                dequeuedItem = "";
            }
            else {
                dequeuedItem = queue[front];
                front = front + 1;
            }

            return Tuple.Create(dequeuedItem, front);
        }

        // Output the state of the queue
        public static void OutputQueue(string[] queue, int front, int rear) {
            // Testing
            Console.Write("\nQueue: ");
            Console.WriteLine("[{0}]", string.Join(", ", queue));
            Console.WriteLine($"Front: {front}");
            Console.WriteLine($"Rear: {rear}");
        }
        

    }
}