using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000116 RID: 278
	public enum SpeechError
	{
		// Token: 0x04001227 RID: 4647
		NoError,
		// Token: 0x04001228 RID: 4648
		TopicLanguageNotSupported,
		// Token: 0x04001229 RID: 4649
		GrammarLanguageMismatch,
		// Token: 0x0400122A RID: 4650
		GrammarCompilationFailure,
		// Token: 0x0400122B RID: 4651
		AudioQualityFailure,
		// Token: 0x0400122C RID: 4652
		PauseLimitExceeded,
		// Token: 0x0400122D RID: 4653
		TimeoutExceeded,
		// Token: 0x0400122E RID: 4654
		NetworkFailure,
		// Token: 0x0400122F RID: 4655
		MicrophoneUnavailable,
		// Token: 0x04001230 RID: 4656
		UnknownError
	}
}
