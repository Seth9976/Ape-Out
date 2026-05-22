using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired.Utils
{
	// Token: 0x02000215 RID: 533
	public class EnumValueHelper<TEnum> : Object
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x0010FE00 File Offset: 0x0010E000
		// Note: this type is marked as 'beforefieldinit'.
		static EnumValueHelper()
		{
			Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "EnumValueHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr);
			EnumValueHelper<TEnum>.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, "uosTDNMCuodpKVbExRdngcDMBdu");
			EnumValueHelper<TEnum>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, "HBIIXimIAqIVHGkNXwXTiuSAgUDD");
			EnumValueHelper<TEnum>.NativeFieldInfoPtr_fsvqxnPkglgbZLdmvKoqcjHSDxL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, "fsvqxnPkglgbZLdmvKoqcjHSDxL");
			EnumValueHelper<TEnum>.NativeFieldInfoPtr_fLRqSecCrIbjCwvVUxLZmPmlGJc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, "fLRqSecCrIbjCwvVUxLZmPmlGJc");
			EnumValueHelper<TEnum>.NativeFieldInfoPtr_bqYqgNxSNMrUDpJHdDBaQetmCtk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, "bqYqgNxSNMrUDpJHdDBaQetmCtk");
			EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_Default_Public_Static_get_EnumValueHelper_1_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, 100676887);
			EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_values_Public_get_IList_1_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, 100676888);
			EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_names_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, 100676889);
			EnumValueHelper<TEnum>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr, 100676890);
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0010FF20 File Offset: 0x0010E120
		public unsafe static EnumValueHelper<TEnum> Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_Default_Public_Static_get_EnumValueHelper_1_TEnum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumValueHelper<TEnum>>(intPtr3) : null;
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x0010FF54 File Offset: 0x0010E154
		public unsafe IList<TEnum> values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_values_Public_get_IList_1_TEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TEnum>>(intPtr3) : null;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x0010FF94 File Offset: 0x0010E194
		public unsafe IList<string> names
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347309, XrefRangeEnd = 347323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumValueHelper<TEnum>.NativeMethodInfoPtr_get_names_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0010FFD4 File Offset: 0x0010E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347323, XrefRangeEnd = 347341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumValueHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumValueHelper<TEnum>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumValueHelper<TEnum>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00012F5D File Offset: 0x0001115D
		public EnumValueHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00110010 File Offset: 0x0010E210
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x00012F66 File Offset: 0x00011166
		public unsafe static EnumValueHelper<TEnum> uosTDNMCuodpKVbExRdngcDMBdu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumValueHelper<TEnum>.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumValueHelper<TEnum>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumValueHelper<TEnum>.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00110038 File Offset: 0x0010E238
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x00012F78 File Offset: 0x00011178
		public unsafe Il2CppArrayBase<TEnum> HBIIXimIAqIVHGkNXwXTiuSAgUDD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD);
				return Il2CppArrayBase<TEnum>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x00110060 File Offset: 0x0010E260
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x00012F97 File Offset: 0x00011197
		public unsafe ReadOnlyCollection<TEnum> fsvqxnPkglgbZLdmvKoqcjHSDxL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_fsvqxnPkglgbZLdmvKoqcjHSDxL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_fsvqxnPkglgbZLdmvKoqcjHSDxL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00110090 File Offset: 0x0010E290
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x00012FB6 File Offset: 0x000111B6
		public unsafe Il2CppStringArray fLRqSecCrIbjCwvVUxLZmPmlGJc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_fLRqSecCrIbjCwvVUxLZmPmlGJc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_fLRqSecCrIbjCwvVUxLZmPmlGJc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x001100C0 File Offset: 0x0010E2C0
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00012FD5 File Offset: 0x000111D5
		public unsafe ReadOnlyCollection<string> bqYqgNxSNMrUDpJHdDBaQetmCtk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_bqYqgNxSNMrUDpJHdDBaQetmCtk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumValueHelper<TEnum>.NativeFieldInfoPtr_bqYqgNxSNMrUDpJHdDBaQetmCtk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeFieldInfoPtr_HBIIXimIAqIVHGkNXwXTiuSAgUDD;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeFieldInfoPtr_fsvqxnPkglgbZLdmvKoqcjHSDxL;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeFieldInfoPtr_fLRqSecCrIbjCwvVUxLZmPmlGJc;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeFieldInfoPtr_bqYqgNxSNMrUDpJHdDBaQetmCtk;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EnumValueHelper_1_TEnum_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeMethodInfoPtr_get_values_Public_get_IList_1_TEnum_0;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr_get_names_Public_get_IList_1_String_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
