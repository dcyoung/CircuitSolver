using System;
using System.Collections;
using System.Collections.Generic;

namespace DigLogicSolver
{
	//A logicGate class. Extends the base "Node" class and abstracts logic for all basic logic gates (AND, OR, NAND etc).
	public class LogicGate: Node
	{
		public LogicGate () : base()
		{

		}

		public override bool processInputs(Circuit circuit)
		{
			return false;
		}

		public override string toString ()
		{
			return "Default LogicGate.toString()";
		}
	}

	//An AndGate class. Extends the base "LogicGate" class and holds logic for an AND gate.
	public class AndGate: LogicGate
	{
		public AndGate() : base()
		{

		}

		public override bool processInputs(Circuit circuit)
		{
			List<Node> parents = circuit.getParentsOfNode (this);
			Node parent1 = parents [0];
			Node parent2 = parents [1];

			return parent1.isActive() && parent2.isActive();
		}

		public override string toString ()
		{
			return "Default AndGate.toSring()";
		}
	}

	//An OrGate class. Extends the base "LogicGate" class and holds logic for an OR gate.
	public class OrGate: LogicGate
	{
		public OrGate() : base()
		{

		}

		public override bool processInputs(Circuit circuit)
		{
			List<Node> parents = circuit.getParentsOfNode (this);
			Node parent1 = parents [0];
			Node parent2 = parents [1];

			return parent1.isActive() || parent2.isActive();
		}

		public override string toString ()
		{
			return "Default OrGate.toSring()";
		}
	}

	//A NandGate class. Extends the base "LogicGate" class and holds logic for a NAND gate.
	public class NandGate: LogicGate
	{
		public NandGate() : base()
		{

		}

		public override bool processInputs(Circuit circuit)
		{
			List<Node> parents = circuit.getParentsOfNode (this);
			Node parent1 = parents [0];
			Node parent2 = parents [1];

			return !(parent1.isActive() && parent2.isActive());
		}

		public override string toString ()
		{
			return "Default NandGate.toSring()";
		}
	}

}

