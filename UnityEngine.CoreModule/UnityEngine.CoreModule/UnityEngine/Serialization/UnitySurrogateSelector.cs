using System;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x0200027B RID: 635
	public class UnitySurrogateSelector
	{
		// Token: 0x0600228E RID: 8846 RVA: 0x00012705 File Offset: 0x00010905
		public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00012712 File Offset: 0x00010912
		public void ChainSelector(ISurrogateSelector selector)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0001271A File Offset: 0x0001091A
		public ISurrogateSelector GetNextSelector()
		{
			throw new NotImplementedException();
		}
	}
}
