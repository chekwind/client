using UnityEngine;
using System.Collections;

public class PlayerTrainingProtocol:IProtocol{
	
	public void Process(Message_Body info){
		Data_PlayerTraining_R data = Globals.ToObject<Data_PlayerTraining_R> (info.body);
		if (data != null) {
			if(data.result){
				Globals.It.MainGamer.proMain.bNeedRefresh=true;
				Globals.It.RefreshPlayerList();
				Globals.It.ShowMainView();
//				Globals.It.ShowSuccess(data.message);
			}
			else{
				Globals.It.HideWaiting();
				Globals.It.ShowWarn(Const_ITextID.Msg_Tishi,data.message,null);
				Globals.It.RefreshPlayerView();
			}
		}else{
			Globals.It.NetManager.RoleLogin();
		}
	}
	
	public int iCommand{
		get{
			return Const_ICommand.PlayerTraining;
		}
	}
}