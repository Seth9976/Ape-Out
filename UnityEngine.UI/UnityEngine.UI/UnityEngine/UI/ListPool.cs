using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003C RID: 60
	public static class ListPool<T> : Object
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x00025374 File Offset: 0x00023574
		// Note: this type is marked as 'beforefieldinit'.
		static ListPool()
		{
			Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr);
			ListPool<T>.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "s_ListPool");
			ListPool<T>.NativeMethodInfoPtr_Clear_Private_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664558);
			ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664559);
			ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100664560);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00025430 File Offset: 0x00023630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529239, XrefRangeEnd = 529242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(List<T> l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Clear_Private_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00025468 File Offset: 0x00023668
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 529254, RefRangeEnd = 529275, XrefRangeStart = 529242, XrefRangeEnd = 529254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002549C File Offset: 0x0002369C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 529300, RefRangeEnd = 529321, XrefRangeStart = 529275, XrefRangeEnd = 529300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00004A7A File Offset: 0x00002C7A
		public ListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x000254D4 File Offset: 0x000236D4
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe static ObjectPool<List<T>> s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListPool<T>.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListPool<T>.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Static_Void_List_1_T_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;
	}
}
