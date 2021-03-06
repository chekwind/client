using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainView:MonoBehaviour{
	
	public GamerStat gamerStat;

	void Start(){
		RefreshGamerStat ();
	}

	void onBag(){
		Data_BagInfo data = new Data_BagInfo (){
			characterId=Globals.It.MainGamer.proMain.iCharacterId,
		};
		Globals.It.SendMsg (data, Const_ICommand.BagInfo);
	}
	void onChat(){
		Globals.It.ShowWarn (1, 13, null);
	}
	void onFuli(){
		Globals.It.ShowWarn (1, 13, null);
	}
	void onMail(){
		Data_GetEmails data = new Data_GetEmails (){
			characterId=Globals.It.MainGamer.proMain.iCharacterId,
		};
		Globals.It.SendMsg (data, Const_ICommand.GetEmails);
	}
	void onManage(){
		Globals.It.ShowLineUp();
	}
	void onRank(){
		Globals.It.ShowWarn (1, 13, null);
	}
	void onQiutan(){
		Data_PlayerInner data = new Data_PlayerInner (){
			characterId=Globals.It.MainGamer.proMain.iCharacterId,
		};
		Globals.It.SendMsg (data, Const_ICommand.PlayerInner);
	}
	void onTask(){
		Data_GetTask data = new Data_GetTask (){
			characterId=Globals.It.MainGamer.proMain.iCharacterId,
		};
		Globals.It.SendMsg (data, Const_ICommand.GetTask);
	}
	void onTrade(){
		Globals.It.ShowWarn (1, 13, null);
	}
	void onShop(){
		Data_StoreInfo data = new Data_StoreInfo (){
			characterId=Globals.It.MainGamer.proMain.iCharacterId,
			shopCategory=1,
		};
		Globals.It.SendMsg (data, Const_ICommand.StoreInfo);
	}
	void onMatch(){
		Globals.It.ShowGameCenter();
	}
	public void RefreshGamerStat(){
		gamerStat.Refresh ();
	}
}