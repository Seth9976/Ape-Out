using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x0200002F RID: 47
	public static class TMP_ListPool<T> : Object
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x0001C290 File Offset: 0x0001A490
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ListPool()
		{
			Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr);
			TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "s_ListPool");
			TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100663957);
			TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100663958);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001C338 File Offset: 0x0001A538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 456925, RefRangeEnd = 456930, XrefRangeStart = 456913, XrefRangeEnd = 456925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001C36C File Offset: 0x0001A56C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 456964, RefRangeEnd = 456969, XrefRangeStart = 456930, XrefRangeEnd = 456964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00004613 File Offset: 0x00002813
		public TMP_ListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0000461C File Offset: 0x0000281C
		public unsafe static TMP_ObjectPool<List<T>> s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

		// Token: 0x0200009A RID: 154
		[ObfuscatedName("TMPro.TMP_ListPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F5F RID: 3935 RVA: 0x0003D548 File Offset: 0x0003B748
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr);
				TMP_ListPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, "<>9");
				TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100663961);
				TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100663962);
			}

			// Token: 0x06000F60 RID: 3936 RVA: 0x0003D5EC File Offset: 0x0003B7EC
			[CallerCount(0)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F61 RID: 3937 RVA: 0x0003D628 File Offset: 0x0003B828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456908, XrefRangeEnd = 456913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_0(List<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F62 RID: 3938 RVA: 0x000094C4 File Offset: 0x000076C4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0003D66C File Offset: 0x0003B86C
			// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000094CD File Offset: 0x000076CD
			public unsafe static TMP_ListPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ListPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C2A RID: 3114
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C2B RID: 3115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C2C RID: 3116
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0;
		}
	}
}
