using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200005C RID: 92
	public static class TMP_TextUtilities : global::Il2CppSystem.Object
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x000314F0 File Offset: 0x0002F6F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextUtilities()
		{
			Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr);
			TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "m_rectWorldCorners");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringL");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringU");
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664615);
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664616);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664617);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664618);
			TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664619);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664620);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664621);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664622);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664623);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664624);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664625);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664626);
			TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664627);
			TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664628);
			TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664629);
			TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664630);
			TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664631);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664632);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664633);
			TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664634);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664635);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664636);
			TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664637);
			TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664638);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0003173C File Offset: 0x0002F93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463495, XrefRangeEnd = 463506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000317A0 File Offset: 0x0002F9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463520, RefRangeEnd = 463521, XrefRangeStart = 463506, XrefRangeEnd = 463520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00031810 File Offset: 0x0002FA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463531, RefRangeEnd = 463532, XrefRangeStart = 463521, XrefRangeEnd = 463531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00031874 File Offset: 0x0002FA74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463557, RefRangeEnd = 463558, XrefRangeStart = 463532, XrefRangeEnd = 463557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000318F4 File Offset: 0x0002FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463558, XrefRangeEnd = 463566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00031958 File Offset: 0x0002FB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463566, XrefRangeEnd = 463584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000319C8 File Offset: 0x0002FBC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463609, RefRangeEnd = 463610, XrefRangeStart = 463584, XrefRangeEnd = 463609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00031A38 File Offset: 0x0002FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463610, XrefRangeEnd = 463655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00031A9C File Offset: 0x0002FC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463655, XrefRangeEnd = 463710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00031B00 File Offset: 0x0002FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463710, XrefRangeEnd = 463720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00031B64 File Offset: 0x0002FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463720, XrefRangeEnd = 463757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00031BC8 File Offset: 0x0002FDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463757, XrefRangeEnd = 463814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00031C2C File Offset: 0x0002FE2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 463815, RefRangeEnd = 463827, XrefRangeStart = 463814, XrefRangeEnd = 463815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00031CA4 File Offset: 0x0002FEA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 463846, RefRangeEnd = 463858, XrefRangeStart = 463827, XrefRangeEnd = 463846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00031D14 File Offset: 0x0002FF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463858, XrefRangeEnd = 463864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersectingPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00031D7C File Offset: 0x0002FF7C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 463864, RefRangeEnd = 463892, XrefRangeStart = 463864, XrefRangeEnd = 463864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463894, RefRangeEnd = 463895, XrefRangeStart = 463892, XrefRangeEnd = 463894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00031E18 File Offset: 0x00030018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463897, RefRangeEnd = 463898, XrefRangeStart = 463895, XrefRangeEnd = 463897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00031E58 File Offset: 0x00030058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463900, RefRangeEnd = 463902, XrefRangeStart = 463898, XrefRangeEnd = 463900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00031E98 File Offset: 0x00030098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463902, XrefRangeEnd = 463907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00031EDC File Offset: 0x000300DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSimpleHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00031F20 File Offset: 0x00030120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463907, XrefRangeEnd = 463912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSimpleHashCodeLowercase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00031F64 File Offset: 0x00030164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463912, RefRangeEnd = 463913, XrefRangeStart = 463912, XrefRangeEnd = 463912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexToInt(char hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00031FA4 File Offset: 0x000301A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463913, XrefRangeEnd = 463920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringHexToInt(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000076DD File Offset: 0x000058DD
		public TMP_TextUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00031FE8 File Offset: 0x000301E8
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x000076E6 File Offset: 0x000058E6
		public unsafe static Il2CppStructArray<Vector3> m_rectWorldCorners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00032010 File Offset: 0x00030210
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x000076F8 File Offset: 0x000058F8
		public unsafe static string k_lookupStringL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00032030 File Offset: 0x00030230
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0000770A File Offset: 0x0000590A
		public unsafe static string k_lookupStringU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_m_rectWorldCorners;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringL;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringU;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0;

		// Token: 0x020000AE RID: 174
		[StructLayout(2)]
		public struct LineSegment
		{
			// Token: 0x06000FFA RID: 4090 RVA: 0x0003EFD8 File Offset: 0x0003D1D8
			// Note: this type is marked as 'beforefieldinit'.
			static LineSegment()
			{
				Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "LineSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr);
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point1");
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point2");
				TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, 100664640);
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x0003F040 File Offset: 0x0003D240
			[CallerCount(0)]
			public unsafe LineSegment(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FFC RID: 4092 RVA: 0x00009A3E File Offset: 0x00007C3E
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C89 RID: 3209
			private static readonly IntPtr NativeFieldInfoPtr_Point1;

			// Token: 0x04000C8A RID: 3210
			private static readonly IntPtr NativeFieldInfoPtr_Point2;

			// Token: 0x04000C8B RID: 3211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

			// Token: 0x04000C8C RID: 3212
			[FieldOffset(0)]
			public Vector3 Point1;

			// Token: 0x04000C8D RID: 3213
			[FieldOffset(12)]
			public Vector3 Point2;
		}
	}
}
