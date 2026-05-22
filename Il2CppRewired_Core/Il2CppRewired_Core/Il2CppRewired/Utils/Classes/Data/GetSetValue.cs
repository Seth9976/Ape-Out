using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001CF RID: 463
	public sealed class GetSetValue<T> : Object
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x000F1448 File Offset: 0x000EF648
		// Note: this type is marked as 'beforefieldinit'.
		static GetSetValue()
		{
			Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "GetSetValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr);
			GetSetValue<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, "TreTQUVhkjHdtjTvdDldaYUnVgyz");
			GetSetValue<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, "oVPVyWUbXVJAVAOdhOFwgOwomNH");
			GetSetValue<T>.NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675692);
			GetSetValue<T>.NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675693);
			GetSetValue<T>.NativeMethodInfoPtr_get_setValueDelegate_Public_get_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675694);
			GetSetValue<T>.NativeMethodInfoPtr_set_setValueDelegate_Public_set_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675695);
			GetSetValue<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675696);
			GetSetValue<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675697);
			GetSetValue<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr, 100675698);
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000F1568 File Offset: 0x000EF768
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x000F15A8 File Offset: 0x000EF7A8
		public unsafe Func<T> getValueDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x000F15EC File Offset: 0x000EF7EC
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x000F162C File Offset: 0x000EF82C
		public unsafe Action<T> setValueDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_get_setValueDelegate_Public_get_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_set_setValueDelegate_Public_set_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000F1670 File Offset: 0x000EF870
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 298338, RefRangeEnd = 298357, XrefRangeStart = 298338, XrefRangeEnd = 298357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSetValue(Func<T> getValueDelegate, Action<T> setValueDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSetValue<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getValueDelegate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000F16D0 File Offset: 0x000EF8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335375, XrefRangeEnd = 335381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000F170C File Offset: 0x000EF90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335381, XrefRangeEnd = 335423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetValue<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000117AD File Offset: 0x0000F9AD
		public GetSetValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000F179C File Offset: 0x000EF99C
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x000117B6 File Offset: 0x0000F9B6
		public unsafe Func<T> TreTQUVhkjHdtjTvdDldaYUnVgyz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetValue<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetValue<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x000F17CC File Offset: 0x000EF9CC
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x000117D5 File Offset: 0x0000F9D5
		public unsafe Action<T> oVPVyWUbXVJAVAOdhOFwgOwomNH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetValue<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetValue<T>.NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeFieldInfoPtr_oVPVyWUbXVJAVAOdhOFwgOwomNH;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_get_setValueDelegate_Public_get_Action_1_T_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_set_setValueDelegate_Public_set_Void_Action_1_T_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_T_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_T_0;
	}
}
