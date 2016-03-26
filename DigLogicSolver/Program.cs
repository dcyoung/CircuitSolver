using System;
using System.Collections;
using System.Collections.Generic;

namespace DigLogicSolver
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyPrinter p = new MyPrinter ();
			p.print ("Hello World!");

			testCircuit1 (true, false);

			p.print("Execution complete. Press any button to exit.");
			Console.ReadLine ();
		}

		public static void testCircuit1(bool src1Val, bool src2Val)
		{
			MyPrinter p = new MyPrinter ();

			Source src1 = new Source (src1Val);
			Source src2 = new Source (src2Val);


			//Create some gates
			AndGate andGate1 = new AndGate ();
			OrGate orGate1 = new OrGate ();
			NandGate nandGate1 = new NandGate ();

			List<Node> nodes = new List<Node> ();
			nodes.Add (src1);
			nodes.Add (src2);
			nodes.Add (andGate1);
			nodes.Add (orGate1);
			nodes.Add (nandGate1);

			Circuit circuit = new Circuit ();
			circuit.addNodes (nodes);

			Node[] testInputs = { src1, src2 };

			circuit.addEdge (testInputs[0], andGate1);
			circuit.addEdge (testInputs[1], andGate1);
			circuit.addEdge (testInputs[0], orGate1);
			circuit.addEdge (testInputs[1], orGate1);
			circuit.addEdge (testInputs[0], nandGate1);
			circuit.addEdge (testInputs[1], nandGate1);


			circuit.printTopologicalSort ();
			circuit.solve ();

			p.print ("Source 1:", testInputs [0].isActive ());
			p.print ("Source 2:", testInputs [1].isActive ());

			p.print ("AND Gate:", andGate1.isActive ());
			p.print ("OR Gate:", orGate1.isActive ());
			p.print ("NAND Gate:", nandGate1.isActive ());

		}

	}
}
