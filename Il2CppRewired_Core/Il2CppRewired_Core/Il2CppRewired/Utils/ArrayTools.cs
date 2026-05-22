using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001EB RID: 491
	public static class ArrayTools : global::Il2CppSystem.Object
	{
		// Token: 0x060031D8 RID: 12760 RVA: 0x000F773C File Offset: 0x000F593C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayTools()
		{
			Il2CppClassPointerStore<ArrayTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "ArrayTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr);
			ArrayTools.NativeMethodInfoPtr_ConvertToIntArray_Public_Static_Il2CppStructArray_1_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675908);
			ArrayTools.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675909);
			ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675910);
			ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675911);
			ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675912);
			ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675913);
			ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675914);
			ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675915);
			ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675916);
			ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675917);
			ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStringArray_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675918);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675919);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675920);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675921);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675922);
			ArrayTools.NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675923);
			ArrayTools.NativeMethodInfoPtr_SortAscending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675924);
			ArrayTools.NativeMethodInfoPtr_SortDescending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675925);
			ArrayTools.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675926);
			ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675927);
			ArrayTools.NativeMethodInfoPtr_Insert_Public_Static_Int32_byref_Il2CppArrayBase_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675928);
			ArrayTools.NativeMethodInfoPtr_RemoveAt_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675929);
			ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675930);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675931);
			ArrayTools.NativeMethodInfoPtr_Add_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675932);
			ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675933);
			ArrayTools.NativeMethodInfoPtr_Insert_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675934);
			ArrayTools.NativeMethodInfoPtr_RemoveAt_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675935);
			ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675936);
			ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675937);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675938);
			ArrayTools.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675939);
			ArrayTools.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675940);
			ArrayTools.NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675941);
			ArrayTools.NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675942);
			ArrayTools.NativeMethodInfoPtr_Expand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675943);
			ArrayTools.NativeMethodInfoPtr_Trim_Public_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675944);
			ArrayTools.NativeMethodInfoPtr_SortNearToFar_Public_Static_Il2CppStructArray_1_RaycastHit_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675945);
			ArrayTools.NativeMethodInfoPtr_MoveEntryUp_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675946);
			ArrayTools.NativeMethodInfoPtr_MoveEntryDown_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675947);
			ArrayTools.NativeMethodInfoPtr_Compact_Public_Static_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675948);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675949);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675950);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675951);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675952);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675953);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675954);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675955);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675956);
			ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675957);
			ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675958);
			ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675959);
			ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675960);
			ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675961);
			ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675962);
			ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675963);
			ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675964);
			ArrayTools.NativeMethodInfoPtr_Count_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675965);
			ArrayTools.NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675966);
			ArrayTools.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675967);
			ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675968);
			ArrayTools.NativeMethodInfoPtr_RemoveDuplicates_Public_Static_Void_byref_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675969);
			ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675970);
			ArrayTools.NativeMethodInfoPtr_ToLowerStripSpaces_Public_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675971);
			ArrayTools.NativeMethodInfoPtr_ToBitmask_Public_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675972);
			ArrayTools.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTools>.NativeClassPtr, 100675973);
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000F7C94 File Offset: 0x000F5E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337511, RefRangeEnd = 337512, XrefRangeStart = 337489, XrefRangeEnd = 337511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> ConvertToIntArray(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ConvertToIntArray_Public_Static_Il2CppStructArray_1_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000F7CD8 File Offset: 0x000F5ED8
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 337523, RefRangeEnd = 337563, XrefRangeStart = 337512, XrefRangeEnd = 337523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> DeepClone<T>(Il2CppArrayBase<T> array) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000F7D14 File Offset: 0x000F5F14
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 337568, RefRangeEnd = 337604, XrefRangeStart = 337563, XrefRangeEnd = 337568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ShallowCopy<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_ShallowCopy_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000F7D50 File Offset: 0x000F5F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337604, XrefRangeEnd = 337610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShallowCopy<T>(Il2CppArrayBase<T> sourceArray, Il2CppArrayBase<T> targetArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_ShallowCopy_Public_Static_Void_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000F7D98 File Offset: 0x000F5F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337610, XrefRangeEnd = 337616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShallowCopy(Il2CppStructArray<int> sourceArray, Il2CppStructArray<int> targetArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000F7DE0 File Offset: 0x000F5FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337616, XrefRangeEnd = 337622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShallowCopy(Il2CppStructArray<float> sourceArray, Il2CppStructArray<float> targetArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000F7E28 File Offset: 0x000F6028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337622, XrefRangeEnd = 337628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShallowCopy(Il2CppStructArray<bool> sourceArray, Il2CppStructArray<bool> targetArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000F7E70 File Offset: 0x000F6070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337628, XrefRangeEnd = 337631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> CopyRange(Il2CppStructArray<byte> inArray, int startPos, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000F7ED0 File Offset: 0x000F60D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337631, XrefRangeEnd = 337634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> CopyRange(Il2CppStructArray<int> inArray, int startPos, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000F7F30 File Offset: 0x000F6130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337634, XrefRangeEnd = 337637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> CopyRange(Il2CppStructArray<float> inArray, int startPos, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000F7F90 File Offset: 0x000F6190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337637, XrefRangeEnd = 337641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray CopyRange(Il2CppStringArray inArray, int startPos, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStringArray_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000F7FF0 File Offset: 0x000F61F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337641, XrefRangeEnd = 337647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Combine(Il2CppStructArray<byte> inArray1, Il2CppStructArray<byte> inArray2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inArray2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000F8048 File Offset: 0x000F6248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337647, XrefRangeEnd = 337653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> Combine(Il2CppStructArray<int> inArray1, Il2CppStructArray<int> inArray2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inArray2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000F80A0 File Offset: 0x000F62A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337653, XrefRangeEnd = 337659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> Combine(Il2CppStructArray<float> inArray1, Il2CppStructArray<float> inArray2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inArray2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000F80F8 File Offset: 0x000F62F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337659, XrefRangeEnd = 337662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Combine(Il2CppStringArray inArray1, Il2CppStringArray inArray2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inArray2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000F8150 File Offset: 0x000F6350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337662, XrefRangeEnd = 337688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ParseArray<T>(string line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_ParseArray_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000F818C File Offset: 0x000F638C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337688, XrefRangeEnd = 337700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> SortAscending<T>(Il2CppArrayBase<T> array, out Il2CppStructArray<int> sortedIndices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_SortAscending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sortedIndices = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000F81EC File Offset: 0x000F63EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337700, XrefRangeEnd = 337712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> SortDescending<T>(Il2CppArrayBase<T> array, out Il2CppStructArray<int> sortedIndices, bool ascending = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascending;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_SortDescending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sortedIndices = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000F825C File Offset: 0x000F645C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337712, XrefRangeEnd = 337717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Add<T>(ref Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref item;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Add_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000F8314 File Offset: 0x000F6514
		[CallerCount(0)]
		public unsafe static int AddIfUnique<T>(ref Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref item;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_AddIfUnique_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000F83CC File Offset: 0x000F65CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337717, XrefRangeEnd = 337722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Insert<T>(ref Il2CppArrayBase<T> array, int index, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref item;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Insert_Public_Static_Int32_byref_Il2CppArrayBase_1_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000F8490 File Offset: 0x000F6690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337722, XrefRangeEnd = 337724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveAt<T>(ref Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_RemoveAt_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000F84F8 File Offset: 0x000F66F8
		[CallerCount(0)]
		public unsafe static bool Remove<T>(ref Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref item;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Remove_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x000F85B0 File Offset: 0x000F67B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337726, RefRangeEnd = 337727, XrefRangeStart = 337724, XrefRangeEnd = 337726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Combine<T>(ref Il2CppArrayBase<T> array1, Il2CppArrayBase<T> array2)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Combine_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array1 = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x000F8610 File Offset: 0x000F6810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337727, XrefRangeEnd = 337732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> Add<T>(Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Add_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x000F86AC File Offset: 0x000F68AC
		[CallerCount(0)]
		public unsafe static Il2CppArrayBase<T> AddIfUnique<T>(Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_AddIfUnique_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000F8748 File Offset: 0x000F6948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337732, XrefRangeEnd = 337737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> Insert<T>(Il2CppArrayBase<T> array, int index, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Insert_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000F87F0 File Offset: 0x000F69F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337737, XrefRangeEnd = 337739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> RemoveAt<T>(Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_RemoveAt_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000F883C File Offset: 0x000F6A3C
		[CallerCount(0)]
		public unsafe static Il2CppArrayBase<T> Remove<T>(Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Remove_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000F88D8 File Offset: 0x000F6AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337739, XrefRangeEnd = 337744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> Combine<T>(Il2CppArrayBase<T> array1, Il2CppArrayBase<T> array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Combine_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000F8928 File Offset: 0x000F6B28
		[CallerCount(0)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000F89C8 File Offset: 0x000F6BC8
		[CallerCount(0)]
		public unsafe static bool Contains<T>(Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000F8A68 File Offset: 0x000F6C68
		[CallerCount(0)]
		public unsafe static T Find<T>(Il2CppArrayBase<T> array, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x000F8AB8 File Offset: 0x000F6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337744, XrefRangeEnd = 337746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubArray<T>(ref Il2CppArrayBase<T> array, int startIndex)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000F8B20 File Offset: 0x000F6D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337746, XrefRangeEnd = 337749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubArray<T>(ref Il2CppArrayBase<T> array, int startIndex, int count)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000F8B94 File Offset: 0x000F6D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337755, RefRangeEnd = 337756, XrefRangeStart = 337749, XrefRangeEnd = 337755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Expand<T>(ref Il2CppArrayBase<T> array, int length)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Expand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000F8BF0 File Offset: 0x000F6DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337756, XrefRangeEnd = 337757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Trim(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Trim_Public_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000F8C28 File Offset: 0x000F6E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337757, XrefRangeEnd = 337769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> SortNearToFar(Il2CppStructArray<RaycastHit> hits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_SortNearToFar_Public_Static_Il2CppStructArray_1_RaycastHit_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000F8C6C File Offset: 0x000F6E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337769, XrefRangeEnd = 337771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveEntryUp<T>(Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_MoveEntryUp_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000F8CB0 File Offset: 0x000F6EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337771, XrefRangeEnd = 337773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveEntryDown<T>(Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_MoveEntryDown_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000F8CF4 File Offset: 0x000F6EF4
		[CallerCount(0)]
		public unsafe static void Compact<T>(ref Il2CppArrayBase<T> array) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Compact_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000F8D40 File Offset: 0x000F6F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337773, XrefRangeEnd = 337774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<int> array, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000F8D90 File Offset: 0x000F6F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337774, XrefRangeEnd = 337775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<float> array, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000F8DE0 File Offset: 0x000F6FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337775, XrefRangeEnd = 337776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<short> array, short value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000F8E30 File Offset: 0x000F7030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<ushort> array, ushort value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000F8E80 File Offset: 0x000F7080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<uint> array, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000F8ED0 File Offset: 0x000F70D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337776, XrefRangeEnd = 337777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<double> array, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000F8F20 File Offset: 0x000F7120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337777, XrefRangeEnd = 337778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<bool> array, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000F8F70 File Offset: 0x000F7170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337778, XrefRangeEnd = 337779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStringArray array, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x000F8FC4 File Offset: 0x000F71C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337779, XrefRangeEnd = 337782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStringArray array, string value, StringComparison stringComparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringComparison;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x000F9028 File Offset: 0x000F7228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337782, XrefRangeEnd = 337783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x000F90BC File Offset: 0x000F72BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337783, XrefRangeEnd = 337784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000F9160 File Offset: 0x000F7360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337784, XrefRangeEnd = 337785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x000F9210 File Offset: 0x000F7410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337786, RefRangeEnd = 337787, XrefRangeStart = 337785, XrefRangeEnd = 337786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Populate<T>(Il2CppArrayBase<T> array, int startIndex, int length, Func<T> instantiator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instantiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000F9274 File Offset: 0x000F7474
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 337788, RefRangeEnd = 337798, XrefRangeStart = 337787, XrefRangeEnd = 337788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Populate<T>(Il2CppArrayBase<T> array, int startIndex, int length) where T : class, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000F92C8 File Offset: 0x000F74C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337798, XrefRangeEnd = 337804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Populate<T>(Il2CppArrayBase<T> array) where T : class, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000F9300 File Offset: 0x000F7500
		[CallerCount(0)]
		public unsafe static void Populate<T>(Il2CppArrayBase<T> array, Func<T> instantiator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instantiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000F9348 File Offset: 0x000F7548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337804, XrefRangeEnd = 337805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<T>(Il2CppArrayBase<T> array, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_Count_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000F939C File Offset: 0x000F759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337805, XrefRangeEnd = 337806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEqual(Il2CppStructArray<byte> a1, Il2CppStructArray<byte> a2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000F93F0 File Offset: 0x000F75F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337809, RefRangeEnd = 337810, XrefRangeStart = 337806, XrefRangeEnd = 337809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains(Il2CppStringArray array, string item, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppStringArray_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000F9454 File Offset: 0x000F7654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337810, XrefRangeEnd = 337812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddIfUnique(ref Il2CppStringArray array, string item, bool ignoreCase)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppStringArray_String_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppStringArray(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000F94CC File Offset: 0x000F76CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337812, XrefRangeEnd = 337823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDuplicates(ref Il2CppStringArray array, bool ignoreCase)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_RemoveDuplicates_Public_Static_Void_byref_Il2CppStringArray_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppStringArray(intPtr4));
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000F9528 File Offset: 0x000F7728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337823, XrefRangeEnd = 337827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Remove(ref Il2CppStringArray array, string item, bool ignoreCase)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppStringArray_String_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppStringArray(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000F95A0 File Offset: 0x000F77A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337827, XrefRangeEnd = 337839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ToLowerStripSpaces(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ToLowerStripSpaces_Public_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000F95E4 File Offset: 0x000F77E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337839, XrefRangeEnd = 337840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBitmask(Il2CppStructArray<bool> array, int startIndex, int count = 32)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.NativeMethodInfoPtr_ToBitmask_Public_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000F9644 File Offset: 0x000F7844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337845, RefRangeEnd = 337847, XrefRangeStart = 337840, XrefRangeEnd = 337845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTools.MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00011CD8 File Offset: 0x0000FED8
		public ArrayTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToIntArray_Public_Static_Il2CppStructArray_1_Int32_Array_0;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Int32_Int32_0;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeMethodInfoPtr_CopyRange_Public_Static_Il2CppStringArray_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr_SortAscending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr_SortDescending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_Boolean_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Static_Int32_byref_Il2CppArrayBase_1_T_Int32_T_0;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeMethodInfoPtr_AddIfUnique_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_T_0;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Static_Void_Il2CppStringArray_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr_SortNearToFar_Public_Static_Il2CppStructArray_1_RaycastHit_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr_MoveEntryUp_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_MoveEntryDown_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_Compact_Public_Static_Void_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Single_Single_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Int16_Int16_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt16_UInt16_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Double_Double_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStructArray_1_Boolean_Boolean_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppStringArray_String_StringComparison_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_1_T_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Func_1_T_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppStringArray_String_Boolean_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppStringArray_String_Boolean_0;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicates_Public_Static_Void_byref_Il2CppStringArray_Boolean_0;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppStringArray_String_Boolean_0;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerStripSpaces_Public_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeMethodInfoPtr_ToBitmask_Public_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_Il2CppArrayBase_1_T_0;

		// Token: 0x02000407 RID: 1031
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400434E RID: 17230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000408 RID: 1032
		private sealed class MethodInfoStoreGeneric_ShallowCopy_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400434F RID: 17231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000409 RID: 1033
		private sealed class MethodInfoStoreGeneric_ShallowCopy_Public_Static_Void_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004350 RID: 17232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_Void_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040A RID: 1034
		private sealed class MethodInfoStoreGeneric_ParseArray_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04004351 RID: 17233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040B RID: 1035
		private sealed class MethodInfoStoreGeneric_SortAscending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_0<T>
		{
			// Token: 0x04004352 RID: 17234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_SortAscending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040C RID: 1036
		private sealed class MethodInfoStoreGeneric_SortDescending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_Boolean_0<T>
		{
			// Token: 0x04004353 RID: 17235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_SortDescending_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_byref_Il2CppStructArray_1_Int32_Boolean_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040D RID: 1037
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004354 RID: 17236
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040E RID: 1038
		private sealed class MethodInfoStoreGeneric_AddIfUnique_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004355 RID: 17237
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Int32_byref_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200040F RID: 1039
		private sealed class MethodInfoStoreGeneric_Insert_Public_Static_Int32_byref_Il2CppArrayBase_1_T_Int32_T_0<T>
		{
			// Token: 0x04004356 RID: 17238
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Insert_Public_Static_Int32_byref_Il2CppArrayBase_1_T_Int32_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000410 RID: 1040
		private sealed class MethodInfoStoreGeneric_RemoveAt_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004357 RID: 17239
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_RemoveAt_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000411 RID: 1041
		private sealed class MethodInfoStoreGeneric_Remove_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004358 RID: 17240
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000412 RID: 1042
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004359 RID: 17241
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000413 RID: 1043
		private sealed class MethodInfoStoreGeneric_Add_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x0400435A RID: 17242
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Add_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000414 RID: 1044
		private sealed class MethodInfoStoreGeneric_AddIfUnique_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x0400435B RID: 17243
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000415 RID: 1045
		private sealed class MethodInfoStoreGeneric_Insert_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_T_0<T>
		{
			// Token: 0x0400435C RID: 17244
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Insert_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000416 RID: 1046
		private sealed class MethodInfoStoreGeneric_RemoveAt_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400435D RID: 17245
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_RemoveAt_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000417 RID: 1047
		private sealed class MethodInfoStoreGeneric_Remove_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x0400435E RID: 17246
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Remove_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000418 RID: 1048
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400435F RID: 17247
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Combine_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000419 RID: 1049
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004360 RID: 17248
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041A RID: 1050
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004361 RID: 17249
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041B RID: 1051
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004362 RID: 17250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041C RID: 1052
		private sealed class MethodInfoStoreGeneric_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004363 RID: 17251
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041D RID: 1053
		private sealed class MethodInfoStoreGeneric_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04004364 RID: 17252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_SubArray_Public_Static_Boolean_byref_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041E RID: 1054
		private sealed class MethodInfoStoreGeneric_Expand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004365 RID: 17253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Expand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200041F RID: 1055
		private sealed class MethodInfoStoreGeneric_MoveEntryUp_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004366 RID: 17254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_MoveEntryUp_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000420 RID: 1056
		private sealed class MethodInfoStoreGeneric_MoveEntryDown_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004367 RID: 17255
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_MoveEntryDown_Public_Static_Void_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000421 RID: 1057
		private sealed class MethodInfoStoreGeneric_Compact_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004368 RID: 17256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Compact_Public_Static_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000422 RID: 1058
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004369 RID: 17257
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000423 RID: 1059
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0<T>
		{
			// Token: 0x0400436A RID: 17258
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000424 RID: 1060
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x0400436B RID: 17259
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000425 RID: 1061
		private sealed class MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_1_T_0<T>
		{
			// Token: 0x0400436C RID: 17260
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000426 RID: 1062
		private sealed class MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x0400436D RID: 17261
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000427 RID: 1063
		private sealed class MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400436E RID: 17262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000428 RID: 1064
		private sealed class MethodInfoStoreGeneric_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Func_1_T_0<T>
		{
			// Token: 0x0400436F RID: 17263
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Populate_Public_Static_Void_Il2CppArrayBase_1_T_Func_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000429 RID: 1065
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004370 RID: 17264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_Count_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200042A RID: 1066
		private sealed class MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004371 RID: 17265
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayTools.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
