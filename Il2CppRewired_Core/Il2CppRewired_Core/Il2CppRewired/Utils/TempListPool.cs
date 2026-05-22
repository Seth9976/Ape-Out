using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001EA RID: 490
	public static class TempListPool : Object
	{
		// Token: 0x060031C5 RID: 12741 RVA: 0x000F7304 File Offset: 0x000F5504
		// Note: this type is marked as 'beforefieldinit'.
		static TempListPool()
		{
			Il2CppClassPointerStore<TempListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "TempListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempListPool>.NativeClassPtr);
			TempListPool.NativeFieldInfoPtr_nKYpckfvDZPIeGgunfcoePmtUNGg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "nKYpckfvDZPIeGgunfcoePmtUNGg");
			TempListPool.NativeFieldInfoPtr_pqfLBCmGCXcsohJdHfozYyBQknB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "pqfLBCmGCXcsohJdHfozYyBQknB");
			TempListPool.NativeFieldInfoPtr_fWyFEQcgSrSHGIdttFaKBYoWBnFE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "fWyFEQcgSrSHGIdttFaKBYoWBnFE");
			TempListPool.NativeMethodInfoPtr_get_lists_Private_Static_get_ADictionary_2_Type_List_1_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675883);
			TempListPool.NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675884);
			TempListPool.NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675885);
			TempListPool.NativeMethodInfoPtr_ReturnTList_Public_Static_Void_TList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675886);
			TempListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675887);
			TempListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675888);
			TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675889);
			TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675890);
			TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675891);
			TempListPool.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675892);
			TempListPool.NativeMethodInfoPtr_Clear_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, 100675893);
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000F744C File Offset: 0x000F564C
		public unsafe static ADictionary<Type, List<IList>> lists
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 337395, RefRangeEnd = 337400, XrefRangeStart = 337387, XrefRangeEnd = 337395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.NativeMethodInfoPtr_get_lists_Private_Static_get_ADictionary_2_Type_List_1_IList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ADictionary<Type, List<IList>>>(intPtr3) : null;
			}
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000F7480 File Offset: 0x000F5680
		[CallerCount(0)]
		public unsafe static TempListPool.TList<T> GetTList<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_GetTList_Public_Static_TList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempListPool.TList<T>>(intPtr3) : null;
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000F74B4 File Offset: 0x000F56B4
		[CallerCount(0)]
		public unsafe static TempListPool.TList<T> GetTList<T>(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_GetTList_Public_Static_TList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempListPool.TList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000F74F4 File Offset: 0x000F56F4
		[CallerCount(0)]
		public unsafe static void ReturnTList<T>(TempListPool.TList<T> tList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_ReturnTList_Public_Static_Void_TList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000F752C File Offset: 0x000F572C
		[CallerCount(0)]
		public unsafe static List<T> Get<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_Get_Public_Static_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000F7560 File Offset: 0x000F5760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337400, XrefRangeEnd = 337443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get<T>(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_Get_Public_Static_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000F75A0 File Offset: 0x000F57A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337443, XrefRangeEnd = 337469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Return<T>(List<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000F75D8 File Offset: 0x000F57D8
		[CallerCount(0)]
		public unsafe static void Return<T>(List<T> list1, List<T> list2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000F7620 File Offset: 0x000F5820
		[CallerCount(0)]
		public unsafe static void Return<T>(List<T> list1, List<T> list2, List<T> list3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000F767C File Offset: 0x000F587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337469, XrefRangeEnd = 337473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000F76A4 File Offset: 0x000F58A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337473, XrefRangeEnd = 337489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(Type listType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.NativeMethodInfoPtr_Clear_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00011CA1 File Offset: 0x0000FEA1
		public TempListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000F76DC File Offset: 0x000F58DC
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00011CAA File Offset: 0x0000FEAA
		public unsafe static int nKYpckfvDZPIeGgunfcoePmtUNGg
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TempListPool.NativeFieldInfoPtr_nKYpckfvDZPIeGgunfcoePmtUNGg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TempListPool.NativeFieldInfoPtr_nKYpckfvDZPIeGgunfcoePmtUNGg, (void*)(&value));
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000F76F8 File Offset: 0x000F58F8
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		public unsafe static int pqfLBCmGCXcsohJdHfozYyBQknB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TempListPool.NativeFieldInfoPtr_pqfLBCmGCXcsohJdHfozYyBQknB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TempListPool.NativeFieldInfoPtr_pqfLBCmGCXcsohJdHfozYyBQknB, (void*)(&value));
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000F7714 File Offset: 0x000F5914
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x00011CC6 File Offset: 0x0000FEC6
		public unsafe static ADictionary<Type, List<IList>> fWyFEQcgSrSHGIdttFaKBYoWBnFE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TempListPool.NativeFieldInfoPtr_fWyFEQcgSrSHGIdttFaKBYoWBnFE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<Type, List<IList>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TempListPool.NativeFieldInfoPtr_fWyFEQcgSrSHGIdttFaKBYoWBnFE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeFieldInfoPtr_nKYpckfvDZPIeGgunfcoePmtUNGg;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeFieldInfoPtr_pqfLBCmGCXcsohJdHfozYyBQknB;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeFieldInfoPtr_fWyFEQcgSrSHGIdttFaKBYoWBnFE;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_get_lists_Private_Static_get_ADictionary_2_Type_List_1_IList_0;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_0;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_Int32_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_ReturnTList_Public_Static_Void_TList_1_T_0;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_Int32_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_0;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_List_1_T_0;

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Type_0;

		// Token: 0x020003FC RID: 1020
		public static class pZqQxRGexTyrxbTouWdUWINzyfg : Object
		{
			// Token: 0x060050B1 RID: 20657 RVA: 0x0016EB84 File Offset: 0x0016CD84
			// Note: this type is marked as 'beforefieldinit'.
			static pZqQxRGexTyrxbTouWdUWINzyfg()
			{
				Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "pZqQxRGexTyrxbTouWdUWINzyfg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr);
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeFieldInfoPtr_vPWDVwzoaYIZCcEOoPgpSIhHOLGz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, "vPWDVwzoaYIZCcEOoPgpSIhHOLGz");
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_get_tLists_Private_Static_get_ADictionary_2_Type_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, 100675894);
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_mdLOjyAvNFPFgndzhOdZJuFBWRe_Public_Static_TList_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, 100675895);
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Public_Static_Void_TList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, 100675896);
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, 100675897);
				TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr, 100675898);
			}

			// Token: 0x170018FF RID: 6399
			// (get) Token: 0x060050B2 RID: 20658 RVA: 0x0016EC28 File Offset: 0x0016CE28
			public unsafe static ADictionary<Type, List<Object>> rUKDGNobpWTvJgQIkkEdxxqvdha
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 337282, RefRangeEnd = 337287, XrefRangeStart = 337274, XrefRangeEnd = 337282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_get_tLists_Private_Static_get_ADictionary_2_Type_List_1_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ADictionary<Type, List<Object>>>(intPtr3) : null;
				}
			}

			// Token: 0x060050B3 RID: 20659 RVA: 0x0016EC5C File Offset: 0x0016CE5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337287, XrefRangeEnd = 337325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TempListPool.TList<T> mdLOjyAvNFPFgndzhOdZJuFBWRe<T>(List<T> A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.MethodInfoStoreGeneric_mdLOjyAvNFPFgndzhOdZJuFBWRe_Public_Static_TList_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempListPool.TList<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060050B4 RID: 20660 RVA: 0x0016ECA0 File Offset: 0x0016CEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337325, XrefRangeEnd = 337351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void BRphfmOgywNVrauLZjCEWGRQIij<T>(TempListPool.TList<T> A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.MethodInfoStoreGeneric_BRphfmOgywNVrauLZjCEWGRQIij_Public_Static_Void_TList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050B5 RID: 20661 RVA: 0x0016ECD8 File Offset: 0x0016CED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337351, XrefRangeEnd = 337353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050B6 RID: 20662 RVA: 0x0016ED00 File Offset: 0x0016CF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337353, XrefRangeEnd = 337361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GMFpQqtyJcjzYToWCrZsZQAhPYh(Type A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050B7 RID: 20663 RVA: 0x0001D5DF File Offset: 0x0001B7DF
			public pZqQxRGexTyrxbTouWdUWINzyfg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FE RID: 6398
			// (get) Token: 0x060050B8 RID: 20664 RVA: 0x0016ED38 File Offset: 0x0016CF38
			// (set) Token: 0x060050B9 RID: 20665 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
			public unsafe static ADictionary<Type, List<Object>> vPWDVwzoaYIZCcEOoPgpSIhHOLGz
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeFieldInfoPtr_vPWDVwzoaYIZCcEOoPgpSIhHOLGz, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<Type, List<Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeFieldInfoPtr_vPWDVwzoaYIZCcEOoPgpSIhHOLGz, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004335 RID: 17205
			private static readonly IntPtr NativeFieldInfoPtr_vPWDVwzoaYIZCcEOoPgpSIhHOLGz;

			// Token: 0x04004336 RID: 17206
			private static readonly IntPtr NativeMethodInfoPtr_get_tLists_Private_Static_get_ADictionary_2_Type_List_1_Object_0;

			// Token: 0x04004337 RID: 17207
			private static readonly IntPtr NativeMethodInfoPtr_mdLOjyAvNFPFgndzhOdZJuFBWRe_Public_Static_TList_1_T_List_1_T_0;

			// Token: 0x04004338 RID: 17208
			private static readonly IntPtr NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Public_Static_Void_TList_1_T_0;

			// Token: 0x04004339 RID: 17209
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_0;

			// Token: 0x0400433A RID: 17210
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Static_Void_Type_0;

			// Token: 0x020005AE RID: 1454
			private sealed class MethodInfoStoreGeneric_mdLOjyAvNFPFgndzhOdZJuFBWRe_Public_Static_TList_1_T_List_1_T_0<T>
			{
				// Token: 0x04004F8F RID: 20367
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_mdLOjyAvNFPFgndzhOdZJuFBWRe_Public_Static_TList_1_T_List_1_T_0, Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020005AF RID: 1455
			private sealed class MethodInfoStoreGeneric_BRphfmOgywNVrauLZjCEWGRQIij_Public_Static_Void_TList_1_T_0<T>
			{
				// Token: 0x04004F90 RID: 20368
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg.NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Public_Static_Void_TList_1_T_0, Il2CppClassPointerStore<TempListPool.pZqQxRGexTyrxbTouWdUWINzyfg>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x020003FD RID: 1021
		public class ITListSetter<T> : Il2CppObjectBase
		{
			// Token: 0x060050BA RID: 20666 RVA: 0x0016ED60 File Offset: 0x0016CF60
			// Note: this type is marked as 'beforefieldinit'.
			static ITListSetter()
			{
				Il2CppClassPointerStore<TempListPool.ITListSetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "ITListSetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				TempListPool.ITListSetter<T>.NativeMethodInfoPtr_SetList_Public_Abstract_Virtual_New_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.ITListSetter<T>>.NativeClassPtr, 100675899);
			}

			// Token: 0x060050BB RID: 20667 RVA: 0x0016EDD0 File Offset: 0x0016CFD0
			[CallerCount(0)]
			public unsafe virtual void SetList(List<T> list)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TempListPool.ITListSetter<T>.NativeMethodInfoPtr_SetList_Public_Abstract_Virtual_New_Void_List_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050BC RID: 20668 RVA: 0x0001D5FA File Offset: 0x0001B7FA
			public ITListSetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400433B RID: 17211
			private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Abstract_Virtual_New_Void_List_1_T_0;
		}

		// Token: 0x020003FE RID: 1022
		public sealed class TList<T> : Object
		{
			// Token: 0x060050BD RID: 20669 RVA: 0x0016EE20 File Offset: 0x0016D020
			// Note: this type is marked as 'beforefieldinit'.
			static TList()
			{
				Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TempListPool>.NativeClassPtr, "TList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr);
				TempListPool.TList<T>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, "fxPATlMlJgrpdQJpyRPxIJKzOGb");
				TempListPool.TList<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
				TempListPool.TList<T>.NativeMethodInfoPtr_Create_Public_Static_TList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675900);
				TempListPool.TList<T>.NativeMethodInfoPtr_get_list_Public_get_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675901);
				TempListPool.TList<T>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675902);
				TempListPool.TList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675903);
				TempListPool.TList<T>.NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675904);
				TempListPool.TList<T>.NativeMethodInfoPtr_XtEHljBxBVvXWDrbLDoadsKmBMl_Private_Virtual_Final_New_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675905);
				TempListPool.TList<T>.NativeMethodInfoPtr_CkLucWIAItzQZQIYjiZCzndPTkl_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675906);
				TempListPool.TList<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_List_1_T_TList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr, 100675907);
			}

			// Token: 0x060050BE RID: 20670 RVA: 0x0016EF50 File Offset: 0x0016D150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337361, XrefRangeEnd = 337366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TempListPool.TList<T> Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_Create_Public_Static_TList_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TempListPool.TList<T>>(intPtr3) : null;
			}

			// Token: 0x17001902 RID: 6402
			// (get) Token: 0x060050BF RID: 20671 RVA: 0x0016EF84 File Offset: 0x0016D184
			public unsafe List<T> list
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_get_list_Public_get_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060050C0 RID: 20672 RVA: 0x0016EFC4 File Offset: 0x0016D1C4
			[CallerCount(0)]
			public unsafe TList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempListPool.TList<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C1 RID: 20673 RVA: 0x0016F000 File Offset: 0x0016D200
			[CallerCount(0)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C2 RID: 20674 RVA: 0x0016F034 File Offset: 0x0016D234
			[CallerCount(0)]
			public unsafe void BRphfmOgywNVrauLZjCEWGRQIij()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C3 RID: 20675 RVA: 0x0016F068 File Offset: 0x0016D268
			[CallerCount(0)]
			public unsafe void XtEHljBxBVvXWDrbLDoadsKmBMl(List<T> A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_XtEHljBxBVvXWDrbLDoadsKmBMl_Private_Virtual_Final_New_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050C4 RID: 20676 RVA: 0x0016F0AC File Offset: 0x0016D2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337366, XrefRangeEnd = 337372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CkLucWIAItzQZQIYjiZCzndPTkl()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_CkLucWIAItzQZQIYjiZCzndPTkl_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C5 RID: 20677 RVA: 0x0016F0D4 File Offset: 0x0016D2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337372, XrefRangeEnd = 337387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator List<T>(TempListPool.TList<T> obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempListPool.TList<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_List_1_T_TList_1_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060050C6 RID: 20678 RVA: 0x0001D603 File Offset: 0x0001B803
			public TList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001900 RID: 6400
			// (get) Token: 0x060050C7 RID: 20679 RVA: 0x0016F118 File Offset: 0x0016D318
			// (set) Token: 0x060050C8 RID: 20680 RVA: 0x0001D60C File Offset: 0x0001B80C
			public unsafe List<T> fxPATlMlJgrpdQJpyRPxIJKzOGb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempListPool.TList<T>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempListPool.TList<T>.NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001901 RID: 6401
			// (get) Token: 0x060050C9 RID: 20681 RVA: 0x0016F148 File Offset: 0x0016D348
			// (set) Token: 0x060050CA RID: 20682 RVA: 0x0001D62B File Offset: 0x0001B82B
			public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempListPool.TList<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempListPool.TList<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
				}
			}

			// Token: 0x0400433C RID: 17212
			private static readonly IntPtr NativeFieldInfoPtr_fxPATlMlJgrpdQJpyRPxIJKzOGb;

			// Token: 0x0400433D RID: 17213
			private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

			// Token: 0x0400433E RID: 17214
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TList_1_T_0;

			// Token: 0x0400433F RID: 17215
			private static readonly IntPtr NativeMethodInfoPtr_get_list_Public_get_List_1_T_0;

			// Token: 0x04004340 RID: 17216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04004341 RID: 17217
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004342 RID: 17218
			private static readonly IntPtr NativeMethodInfoPtr_BRphfmOgywNVrauLZjCEWGRQIij_Private_Void_0;

			// Token: 0x04004343 RID: 17219
			private static readonly IntPtr NativeMethodInfoPtr_XtEHljBxBVvXWDrbLDoadsKmBMl_Private_Virtual_Final_New_Void_List_1_T_0;

			// Token: 0x04004344 RID: 17220
			private static readonly IntPtr NativeMethodInfoPtr_CkLucWIAItzQZQIYjiZCzndPTkl_Private_Static_Void_0;

			// Token: 0x04004345 RID: 17221
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_List_1_T_TList_1_T_0;
		}

		// Token: 0x020003FF RID: 1023
		private sealed class MethodInfoStoreGeneric_GetTList_Public_Static_TList_1_T_0<T>
		{
			// Token: 0x04004346 RID: 17222
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000400 RID: 1024
		private sealed class MethodInfoStoreGeneric_GetTList_Public_Static_TList_1_T_Int32_0<T>
		{
			// Token: 0x04004347 RID: 17223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_GetTList_Public_Static_TList_1_T_Int32_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000401 RID: 1025
		private sealed class MethodInfoStoreGeneric_ReturnTList_Public_Static_Void_TList_1_T_0<T>
		{
			// Token: 0x04004348 RID: 17224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_ReturnTList_Public_Static_Void_TList_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000402 RID: 1026
		private sealed class MethodInfoStoreGeneric_Get_Public_Static_List_1_T_0<T>
		{
			// Token: 0x04004349 RID: 17225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000403 RID: 1027
		private sealed class MethodInfoStoreGeneric_Get_Public_Static_List_1_T_Int32_0<T>
		{
			// Token: 0x0400434A RID: 17226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_T_Int32_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000404 RID: 1028
		private sealed class MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_0<T>
		{
			// Token: 0x0400434B RID: 17227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000405 RID: 1029
		private sealed class MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_List_1_T_0<T>
		{
			// Token: 0x0400434C RID: 17228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000406 RID: 1030
		private sealed class MethodInfoStoreGeneric_Return_Public_Static_Void_List_1_T_List_1_T_List_1_T_0<T>
		{
			// Token: 0x0400434D RID: 17229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TempListPool.NativeMethodInfoPtr_Return_Public_Static_Void_List_1_T_List_1_T_List_1_T_0, Il2CppClassPointerStore<TempListPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
