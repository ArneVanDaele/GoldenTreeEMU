using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.HabboHotel.Items;
using GoldTree.Messages;
using GoldTree.HabboHotel.Rooms;
namespace GoldTree.Communication.Messages.Inventory.Trading
{
	internal sealed class AddItemToTradeEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
			Room @class = GoldTree.GetGame().GetRoomManager().GetRoom(Session.GetHabbo().CurrentRoomId);
			if (@class != null && @class.Boolean_2)
			{
				Trade class2 = @class.method_76(Session.GetHabbo().Id);
				UserItem class3 = Session.GetHabbo().method_23().method_10(Event.PopWiredUInt());
				if (class2 != null && class3 != null)
				{
					class2.method_2(Session.GetHabbo().Id, class3);
				}
			}
		}
	}
}
