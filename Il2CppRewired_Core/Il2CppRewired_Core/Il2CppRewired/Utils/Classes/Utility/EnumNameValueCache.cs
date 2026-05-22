using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020E RID: 526
	public sealed class EnumNameValueCache<TEnum> : Object where TEnum : new()
	{
		// Token: 0x060036AE RID: 13998 RVA: 0x0010E740 File Offset: 0x0010C940
		// Note: this type is marked as 'beforefieldinit'.
		static EnumNameValueCache()
		{
			Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "EnumNameValueCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr);
			EnumNameValueCache<TEnum>.NativeFieldInfoPtr_NgkGbrDcVFnbifLNNpzZRkxmdNt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, "NgkGbrDcVFnbifLNNpzZRkxmdNt");
			EnumNameValueCache<TEnum>.NativeFieldInfoPtr_tkXoglTdRfAqJoqPVpumjplGuzu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, "tkXoglTdRfAqJoqPVpumjplGuzu");
			EnumNameValueCache<TEnum>.NativeFieldInfoPtr_YEDZKsFJXqnYyjRfKWBexyvXNDc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, "YEDZKsFJXqnYyjRfKWBexyvXNDc");
			EnumNameValueCache<TEnum>.NativeFieldInfoPtr_kqmOkwBvgmVuqXyjqqeedGyNBAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, "kqmOkwBvgmVuqXyjqqeedGyNBAN");
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_get_Default_Public_Static_get_EnumNameValueCache_1_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676779);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Free_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676780);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676781);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676782);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetValue_Public_TEnum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676783);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676784);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetName_Public_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676785);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_TryGetName_Public_Boolean_Int64_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676786);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetValueAt_Public_TEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676787);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetNameAt_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676788);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676789);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_IndexOf_Public_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676790);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676791);
			EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr, 100676792);
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x0010E914 File Offset: 0x0010CB14
		public unsafe static EnumNameValueCache<TEnum> Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346910, XrefRangeEnd = 346919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_get_Default_Public_Static_get_EnumNameValueCache_1_TEnum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumNameValueCache<TEnum>>(intPtr3) : null;
			}
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0010E948 File Offset: 0x0010CB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346921, XrefRangeEnd = 346923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Free_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x0010E970 File Offset: 0x0010CB70
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0010E9AC File Offset: 0x0010CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346923, XrefRangeEnd = 346956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumNameValueCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumNameValueCache<TEnum>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0010E9E8 File Offset: 0x0010CBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEnum GetValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetValue_Public_TEnum_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEnum>(intPtr, false, true);
			}
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x0010EA34 File Offset: 0x0010CC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346956, XrefRangeEnd = 346957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string name, out TEnum value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEnum).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_TEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEnum).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEnum>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0010EAD0 File Offset: 0x0010CCD0
		[CallerCount(0)]
		public unsafe string GetName(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetName_Public_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0010EB14 File Offset: 0x0010CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346957, XrefRangeEnd = 346958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetName(long value, out string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_TryGetName_Public_Boolean_Int64_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0010EB78 File Offset: 0x0010CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346958, XrefRangeEnd = 346967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEnum GetValueAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetValueAt_Public_TEnum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEnum>(intPtr, false, true);
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0010EBC0 File Offset: 0x0010CDC0
		[CallerCount(0)]
		public unsafe string GetNameAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_GetNameAt_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x0010EC04 File Offset: 0x0010CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346967, XrefRangeEnd = 346969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0010EC54 File Offset: 0x0010CE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346969, XrefRangeEnd = 346971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_IndexOf_Public_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x0010ECA0 File Offset: 0x0010CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346971, XrefRangeEnd = 346972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0010ECF0 File Offset: 0x0010CEF0
		[CallerCount(0)]
		public unsafe bool Contains(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumNameValueCache<TEnum>.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00012D89 File Offset: 0x00010F89
		public EnumNameValueCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x0010ED3C File Offset: 0x0010CF3C
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x00012D92 File Offset: 0x00010F92
		public unsafe static EnumNameValueCache<TEnum> NgkGbrDcVFnbifLNNpzZRkxmdNt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_NgkGbrDcVFnbifLNNpzZRkxmdNt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumNameValueCache<TEnum>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_NgkGbrDcVFnbifLNNpzZRkxmdNt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x0010ED64 File Offset: 0x0010CF64
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x00012DA4 File Offset: 0x00010FA4
		public unsafe ADictionary<string, TEnum> tkXoglTdRfAqJoqPVpumjplGuzu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_tkXoglTdRfAqJoqPVpumjplGuzu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<string, TEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_tkXoglTdRfAqJoqPVpumjplGuzu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x0010ED94 File Offset: 0x0010CF94
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00012DC3 File Offset: 0x00010FC3
		public unsafe Il2CppStringArray YEDZKsFJXqnYyjRfKWBexyvXNDc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_YEDZKsFJXqnYyjRfKWBexyvXNDc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_YEDZKsFJXqnYyjRfKWBexyvXNDc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x0010EDC4 File Offset: 0x0010CFC4
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x00012DE2 File Offset: 0x00010FE2
		public unsafe Il2CppStructArray<long> kqmOkwBvgmVuqXyjqqeedGyNBAN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_kqmOkwBvgmVuqXyjqqeedGyNBAN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumNameValueCache<TEnum>.NativeFieldInfoPtr_kqmOkwBvgmVuqXyjqqeedGyNBAN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeFieldInfoPtr_NgkGbrDcVFnbifLNNpzZRkxmdNt;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeFieldInfoPtr_tkXoglTdRfAqJoqPVpumjplGuzu;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeFieldInfoPtr_YEDZKsFJXqnYyjRfKWBexyvXNDc;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeFieldInfoPtr_kqmOkwBvgmVuqXyjqqeedGyNBAN;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EnumNameValueCache_1_TEnum_0;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_0;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_TEnum_String_0;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_TEnum_0;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_Int64_0;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeMethodInfoPtr_TryGetName_Public_Boolean_Int64_byref_String_0;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAt_Public_TEnum_Int32_0;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeMethodInfoPtr_GetNameAt_Public_String_Int32_0;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Int64_0;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0;
	}
}
