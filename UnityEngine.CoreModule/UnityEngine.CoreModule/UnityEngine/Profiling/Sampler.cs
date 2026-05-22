using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Profiling
{
	// Token: 0x02000276 RID: 630
	public class Sampler
	{
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000125FB File Offset: 0x000107FB
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00012608 File Offset: 0x00010808
		public Recorder GetRecorder()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00012615 File Offset: 0x00010815
		public static Sampler Get(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00078274 File Offset: 0x00076474
		public static int GetNames(List<string> names)
		{
			return Sampler.GetSamplerNamesInternal(names);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0007828C File Offset: 0x0007648C
		public string GetSamplerName()
		{
			IntPtr intPtr = Sampler.GetSamplerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000782B0 File Offset: 0x000764B0
		public string name
		{
			get
			{
				return this.isValid ? this.GetSamplerName() : null;
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00012622 File Offset: 0x00010822
		public static IntPtr GetRecorderInternal(IntPtr ptr)
		{
			return Sampler.GetRecorderInternalDelegateField(ptr);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0001262F File Offset: 0x0001082F
		public static IntPtr GetSamplerInternal(string name)
		{
			return Sampler.GetSamplerInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00012641 File Offset: 0x00010841
		public static int GetSamplerNamesInternal(List<string> namesScriptingPtr)
		{
			return Sampler.GetSamplerNamesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(namesScriptingPtr));
		}

		// Token: 0x04001C73 RID: 7283
		private static readonly Sampler.GetSamplerNameDelegate GetSamplerNameDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerNameDelegate>("UnityEngine.Profiling.Sampler::GetSamplerName");

		// Token: 0x04001C74 RID: 7284
		private static readonly Sampler.GetRecorderInternalDelegate GetRecorderInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetRecorderInternalDelegate>("UnityEngine.Profiling.Sampler::GetRecorderInternal");

		// Token: 0x04001C75 RID: 7285
		private static readonly Sampler.GetSamplerInternalDelegate GetSamplerInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerInternalDelegate>("UnityEngine.Profiling.Sampler::GetSamplerInternal");

		// Token: 0x04001C76 RID: 7286
		private static readonly Sampler.GetSamplerNamesInternalDelegate GetSamplerNamesInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerNamesInternalDelegate>("UnityEngine.Profiling.Sampler::GetSamplerNamesInternal");

		// Token: 0x02000BD7 RID: 3031
		// (Invoke) Token: 0x06003608 RID: 13832
		private delegate IntPtr GetSamplerNameDelegate(IntPtr @this);

		// Token: 0x02000BD8 RID: 3032
		// (Invoke) Token: 0x0600360A RID: 13834
		private delegate IntPtr GetRecorderInternalDelegate(IntPtr ptr);

		// Token: 0x02000BD9 RID: 3033
		// (Invoke) Token: 0x0600360C RID: 13836
		private delegate IntPtr GetSamplerInternalDelegate(IntPtr name);

		// Token: 0x02000BDA RID: 3034
		// (Invoke) Token: 0x0600360E RID: 13838
		private delegate int GetSamplerNamesInternalDelegate(IntPtr namesScriptingPtr);
	}
}
