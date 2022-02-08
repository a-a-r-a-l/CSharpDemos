												// CONCRETE CLASS (can be instantiated)
	// Base / Parent Class						// Derived / Child Class
	abstract class A							class B : A
	{											{

		void m() { ... }							void m(int i) { .... }			// overload

		void n() { .... }							void n() { ... }				// NOT POSSIBLE

		// permission for override					// may / maynot override
		virtual void o() { .... }					override void o() { .... }		
		
		// cannot have a method body				// MUST override
		// has to be in an ABSTRACT Type
		abstract void p();							override void p() { ... }

	}											}

	// A objA = new A();	// no longer compiler - it is an abstract class (it cannot be instantiated)
	// objA.p();			// no code to execute found!