using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A3 RID: 163
	[Serializable]
	public class CustomCalculation : SerializedMethod
	{
		// Token: 0x06001450 RID: 5200 RVA: 0x00008D2F File Offset: 0x00006F2F
		// Note: this type is marked as 'beforefieldinit'.
		static CustomCalculation()
		{
			Il2CppClassPointerStore<CustomCalculation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "CustomCalculation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCalculation>.NativeClassPtr);
			CustomCalculation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation>.NativeClassPtr, 100666734);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000792F8 File Offset: 0x000774F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomCalculation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCalculation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00008D68 File Offset: 0x00006F68
		public CustomCalculation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
