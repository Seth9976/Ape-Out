using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class SignalTrack : MarkerTrack
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00003327 File Offset: 0x00001527
		// Note: this type is marked as 'beforefieldinit'.
		static SignalTrack()
		{
			Il2CppClassPointerStore<SignalTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr);
			SignalTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr, 100663941);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000136E4 File Offset: 0x000118E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003360 File Offset: 0x00001560
		public SignalTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
