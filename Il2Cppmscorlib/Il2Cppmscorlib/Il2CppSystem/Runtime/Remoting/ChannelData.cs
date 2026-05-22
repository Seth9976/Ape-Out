using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000398 RID: 920
	public class ChannelData : Object
	{
		// Token: 0x06003CEA RID: 15594 RVA: 0x00120E60 File Offset: 0x0011F060
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelData()
		{
			Il2CppClassPointerStore<ChannelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelData>.NativeClassPtr);
			ChannelData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Ref");
			ChannelData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Type");
			ChannelData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Id");
			ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "DelayLoadAsClientChannel");
			ChannelData.NativeFieldInfoPtr__serverProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_serverProviders");
			ChannelData.NativeFieldInfoPtr__clientProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_clientProviders");
			ChannelData.NativeFieldInfoPtr__customProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_customProperties");
			ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672344);
			ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672345);
			ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672346);
			ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672347);
			ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672348);
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x00120F80 File Offset: 0x0011F180
		public unsafe ArrayList ServerProviders
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220166, RefRangeEnd = 220170, XrefRangeStart = 220162, XrefRangeEnd = 220166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00120FC0 File Offset: 0x0011F1C0
		public unsafe ArrayList ClientProviders
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220174, RefRangeEnd = 220178, XrefRangeStart = 220170, XrefRangeEnd = 220174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x00121000 File Offset: 0x0011F200
		public unsafe Hashtable CustomProperties
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 220182, RefRangeEnd = 220188, XrefRangeStart = 220178, XrefRangeEnd = 220182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00121040 File Offset: 0x0011F240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220242, RefRangeEnd = 220243, XrefRangeStart = 220188, XrefRangeEnd = 220242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ChannelData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00121084 File Offset: 0x0011F284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220243, XrefRangeEnd = 220254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00016B99 File Offset: 0x00014D99
		public ChannelData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x001210C0 File Offset: 0x0011F2C0
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x00016BA2 File Offset: 0x00014DA2
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x001210E8 File Offset: 0x0011F2E8
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x00016BC1 File Offset: 0x00014DC1
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x00121110 File Offset: 0x0011F310
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x00016BE0 File Offset: 0x00014DE0
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00121138 File Offset: 0x0011F338
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x00016BFF File Offset: 0x00014DFF
		public unsafe string DelayLoadAsClientChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00121160 File Offset: 0x0011F360
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x00016C1E File Offset: 0x00014E1E
		public unsafe ArrayList _serverProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x00121190 File Offset: 0x0011F390
		// (set) Token: 0x06003CFC RID: 15612 RVA: 0x00016C3D File Offset: 0x00014E3D
		public unsafe ArrayList _clientProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x001211C0 File Offset: 0x0011F3C0
		// (set) Token: 0x06003CFE RID: 15614 RVA: 0x00016C5C File Offset: 0x00014E5C
		public unsafe Hashtable _customProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeFieldInfoPtr_DelayLoadAsClientChannel;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeFieldInfoPtr__serverProviders;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeFieldInfoPtr__clientProviders;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeFieldInfoPtr__customProperties;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0;

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
