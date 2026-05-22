using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000074 RID: 116
	public class kvWKVaeBQXddezXSDwPndoljmlq : Object
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0002C304 File Offset: 0x0002A504
		// Note: this type is marked as 'beforefieldinit'.
		static kvWKVaeBQXddezXSDwPndoljmlq()
		{
			Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "kvWKVaeBQXddezXSDwPndoljmlq");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_kjbfjAafNKEmzQPFVwJfazvjnDLw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, "kjbfjAafNKEmzQPFVwJfazvjnDLw");
			kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IUdgVockSZJHrBqoCrzJpxoAhCsl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, "IUdgVockSZJHrBqoCrzJpxoAhCsl");
			kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IureJIWiffOOuRklEGXOJuKcBGe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, "IureJIWiffOOuRklEGXOJuKcBGe");
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr__ctor_Internal_Void_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664875);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664876);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664877);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_DeviceType_Public_get_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664878);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_DeviceType_Public_set_Void_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664879);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664880);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_Handle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664881);
			kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_NUEPlIJjtjMcqrXYJVPcTviQjpl_Internal_Static_kvWKVaeBQXddezXSDwPndoljmlq_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr, 100664882);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002C410 File Offset: 0x0002A610
		[CallerCount(0)]
		public unsafe kvWKVaeBQXddezXSDwPndoljmlq(ref uyFTixrjAkBbKzWDLagKOETGSBF rawDeviceInfo, string deviceName, IntPtr deviceHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<kvWKVaeBQXddezXSDwPndoljmlq>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rawDeviceInfo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deviceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr__ctor_Internal_Void_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002C478 File Offset: 0x0002A678
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0002C4B0 File Offset: 0x0002A6B0
		public unsafe string gLUOVAyiiQpMVJELTfbBkGrDoPv
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0002C4F4 File Offset: 0x0002A6F4
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x0002C530 File Offset: 0x0002A730
		public unsafe SHTUgTGfOFIkCfNZUIneEnHEBjOA fCqcSBdiDfBZDRwPIEmcBqbjvarN
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_DeviceType_Public_get_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_DeviceType_Public_set_Void_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002C570 File Offset: 0x0002A770
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		public unsafe IntPtr LJcZEfMmiRujaRwTTmgCCkWsLjp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_set_Handle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002C5EC File Offset: 0x0002A7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360122, RefRangeEnd = 360123, XrefRangeStart = 360117, XrefRangeEnd = 360122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static kvWKVaeBQXddezXSDwPndoljmlq NUEPlIJjtjMcqrXYJVPcTviQjpl(ref uyFTixrjAkBbKzWDLagKOETGSBF A_0, string A_1, IntPtr A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kvWKVaeBQXddezXSDwPndoljmlq.NativeMethodInfoPtr_NUEPlIJjtjMcqrXYJVPcTviQjpl_Internal_Static_kvWKVaeBQXddezXSDwPndoljmlq_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<kvWKVaeBQXddezXSDwPndoljmlq>(intPtr3) : null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00006108 File Offset: 0x00004308
		public kvWKVaeBQXddezXSDwPndoljmlq(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002C64C File Offset: 0x0002A84C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00006111 File Offset: 0x00004311
		public unsafe string kjbfjAafNKEmzQPFVwJfazvjnDLw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_kjbfjAafNKEmzQPFVwJfazvjnDLw);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_kjbfjAafNKEmzQPFVwJfazvjnDLw), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002C674 File Offset: 0x0002A874
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00006130 File Offset: 0x00004330
		public unsafe SHTUgTGfOFIkCfNZUIneEnHEBjOA IUdgVockSZJHrBqoCrzJpxoAhCsl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IUdgVockSZJHrBqoCrzJpxoAhCsl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IUdgVockSZJHrBqoCrzJpxoAhCsl)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002C69C File Offset: 0x0002A89C
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0000614B File Offset: 0x0000434B
		public unsafe IntPtr IureJIWiffOOuRklEGXOJuKcBGe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IureJIWiffOOuRklEGXOJuKcBGe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(kvWKVaeBQXddezXSDwPndoljmlq.NativeFieldInfoPtr_IureJIWiffOOuRklEGXOJuKcBGe)) = value;
			}
		}

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_kjbfjAafNKEmzQPFVwJfazvjnDLw;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_IUdgVockSZJHrBqoCrzJpxoAhCsl;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_IureJIWiffOOuRklEGXOJuKcBGe;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_get_String_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_get_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceType_Public_set_Void_SHTUgTGfOFIkCfNZUIneEnHEBjOA_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Public_set_Void_IntPtr_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_NUEPlIJjtjMcqrXYJVPcTviQjpl_Internal_Static_kvWKVaeBQXddezXSDwPndoljmlq_byref_uyFTixrjAkBbKzWDLagKOETGSBF_String_IntPtr_0;
	}
}
