using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000117 RID: 279
	public enum DictationCompletionCause
	{
		// Token: 0x04001232 RID: 4658
		Complete,
		// Token: 0x04001233 RID: 4659
		AudioQualityFailure,
		// Token: 0x04001234 RID: 4660
		Canceled,
		// Token: 0x04001235 RID: 4661
		TimeoutExceeded,
		// Token: 0x04001236 RID: 4662
		PauseLimitExceeded,
		// Token: 0x04001237 RID: 4663
		NetworkFailure,
		// Token: 0x04001238 RID: 4664
		MicrophoneUnavailable,
		// Token: 0x04001239 RID: 4665
		UnknownError
	}
}
