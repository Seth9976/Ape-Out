using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.Common
{
	// Token: 0x02000214 RID: 532
	public class ACTkConstants : Object
	{
		// Token: 0x06001E33 RID: 7731 RVA: 0x00087298 File Offset: 0x00085498
		// Note: this type is marked as 'beforefieldinit'.
		static ACTkConstants()
		{
			Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Common", "ACTkConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr);
			ACTkConstants.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr, "Version");
			ACTkConstants.NativeFieldInfoPtr_LogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr, "LogPrefix");
			ACTkConstants.NativeFieldInfoPtr_DocsRootUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr, "DocsRootUrl");
			ACTkConstants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr, 100668181);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00087318 File Offset: 0x00085518
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACTkConstants()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACTkConstants>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACTkConstants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000AEF4 File Offset: 0x000090F4
		public ACTkConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00087354 File Offset: 0x00085554
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0000AEFD File Offset: 0x000090FD
		public unsafe static string Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ACTkConstants.NativeFieldInfoPtr_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ACTkConstants.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00087374 File Offset: 0x00085574
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000AF0F File Offset: 0x0000910F
		public unsafe static string LogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ACTkConstants.NativeFieldInfoPtr_LogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ACTkConstants.NativeFieldInfoPtr_LogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00087394 File Offset: 0x00085594
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0000AF21 File Offset: 0x00009121
		public unsafe static string DocsRootUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ACTkConstants.NativeFieldInfoPtr_DocsRootUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ACTkConstants.NativeFieldInfoPtr_DocsRootUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeFieldInfoPtr_LogPrefix;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeFieldInfoPtr_DocsRootUrl;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
