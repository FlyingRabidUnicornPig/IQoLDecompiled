using System;

public interface IPunTurnManagerCallbacks
{
	void OnTurnBegins(int JPFFPMDKAMC);

	void OnTurnCompleted(int JPFFPMDKAMC);

	void OnPlayerMove(PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC, object HNOKMIIDHHH);

	void OnPlayerFinished(PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC, object HNOKMIIDHHH);

	void OnTurnTimeEnds(int JPFFPMDKAMC);
}
