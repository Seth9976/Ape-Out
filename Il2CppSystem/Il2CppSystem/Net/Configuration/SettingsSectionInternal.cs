using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200016D RID: 365
	public sealed class SettingsSectionInternal : Object
	{
		// Token: 0x060016E2 RID: 5858 RVA: 0x000667C8 File Offset: 0x000649C8
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSectionInternal()
		{
			Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr);
			SettingsSectionInternal.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "instance");
			SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "HttpListenerUnescapeRequestUrl");
			SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "IPProtectionLevel");
			SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666520);
			SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666521);
			SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666522);
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00066870 File Offset: 0x00064A70
		public unsafe static SettingsSectionInternal Section
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388661, XrefRangeEnd = 388665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr3) : null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000668A4 File Offset: 0x00064AA4
		public unsafe bool Ipv6Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000668E0 File Offset: 0x00064AE0
		[CallerCount(0)]
		public unsafe SettingsSectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0000B636 File Offset: 0x00009836
		public SettingsSectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0006691C File Offset: 0x00064B1C
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000B63F File Offset: 0x0000983F
		public unsafe static SettingsSectionInternal instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00066944 File Offset: 0x00064B44
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000B651 File Offset: 0x00009851
		public unsafe bool HttpListenerUnescapeRequestUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl)) = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x0006696C File Offset: 0x00064B6C
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x0000B66C File Offset: 0x0000986C
		public unsafe IPProtectionLevel IPProtectionLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel)) = value;
			}
		}

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_IPProtectionLevel;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
