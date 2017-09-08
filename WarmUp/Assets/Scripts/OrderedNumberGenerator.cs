using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderedNumberGenerator : NumberGenerator {

	public int[] order;

	int current;

    public override int Next() {

		int result = order[current % order.Length];

        current++;

		return result;

	}

}
