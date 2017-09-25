using System;
using System.Collections;

public class Inventory
{
	private ArrayList items = new ArrayList();
	private ArrayList weapons = new ArrayList();
	//private int capacityItems = 10;
	//private int capacityWeapons = 3;

	public Inventory ()
	{
	}

	public void AddItem (Item item) {
		items.Add (item);
	}

	public void AddWeapon (Weapon weapon) {
		weapons.Add (weapon);
	}

	public string ShowItems () {
		string itemlist = "";
		for (int i = 0; i < items.Count; i++) {
			itemlist += items[i] + " ";
		}
		return itemlist;
	}

	public string ShowWeapons () {
		string weaponlist = "";
		for (int i = 0; i < weapons.Count; i++) {
			weaponlist += weapons [i] + " ";
		}
		return weaponlist;
	}
}
