using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class GUILayout : Object
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00009D44 File Offset: 0x00007F44
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayout()
		{
			Il2CppClassPointerStore<GUILayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayout>.NativeClassPtr);
			GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663433);
			GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663434);
			GUILayout.NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663435);
			GUILayout.NativeMethodInfoPtr_Box_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663436);
			GUILayout.NativeMethodInfoPtr_DoBox_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663437);
			GUILayout.NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663438);
			GUILayout.NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663439);
			GUILayout.NativeMethodInfoPtr_TextArea_Public_Static_String_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663440);
			GUILayout.NativeMethodInfoPtr_DoTextField_Private_Static_String_String_Int32_Boolean_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663441);
			GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663442);
			GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663443);
			GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663444);
			GUILayout.NativeMethodInfoPtr_DoToggle_Private_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663445);
			GUILayout.NativeMethodInfoPtr_Space_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663446);
			GUILayout.NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663447);
			GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663448);
			GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663449);
			GUILayout.NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663450);
			GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663451);
			GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663452);
			GUILayout.NativeMethodInfoPtr_EndVertical_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663453);
			GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663454);
			GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663455);
			GUILayout.NativeMethodInfoPtr_EndArea_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663456);
			GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663457);
			GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663458);
			GUILayout.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663459);
			GUILayout.NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663460);
			GUILayout.NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663461);
			GUILayout.NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663462);
			GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663463);
			GUILayout.NativeMethodInfoPtr_MinWidth_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663464);
			GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663465);
			GUILayout.NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663466);
			GUILayout.NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663467);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A030 File Offset: 0x00008230
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 507159, RefRangeEnd = 507180, XrefRangeStart = 507149, XrefRangeEnd = 507159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000A088 File Offset: 0x00008288
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 507185, RefRangeEnd = 507207, XrefRangeStart = 507180, XrefRangeEnd = 507185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(string text, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A0F0 File Offset: 0x000082F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 507219, RefRangeEnd = 507221, XrefRangeStart = 507207, XrefRangeEnd = 507219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLabel(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000A14C File Offset: 0x0000834C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507221, XrefRangeEnd = 507233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Box(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Box_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoBox(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoBox_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A210 File Offset: 0x00008410
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 507253, RefRangeEnd = 507269, XrefRangeStart = 507233, XrefRangeEnd = 507253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A270 File Offset: 0x00008470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507269, XrefRangeEnd = 507281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507286, RefRangeEnd = 507289, XrefRangeStart = 507281, XrefRangeEnd = 507286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TextArea(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_TextArea_Public_Static_String_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000A334 File Offset: 0x00008534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507339, RefRangeEnd = 507340, XrefRangeStart = 507289, XrefRangeEnd = 507339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoTextField_Private_Static_String_String_Int32_Boolean_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000A3B4 File Offset: 0x000085B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507340, XrefRangeEnd = 507349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Toggle(bool value, string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A424 File Offset: 0x00008624
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 507354, RefRangeEnd = 507367, XrefRangeStart = 507349, XrefRangeEnd = 507354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Toggle(bool value, string text, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A4A4 File Offset: 0x000086A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507367, XrefRangeEnd = 507368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Toggle(bool value, GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A524 File Offset: 0x00008724
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 507380, RefRangeEnd = 507386, XrefRangeStart = 507368, XrefRangeEnd = 507380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoToggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoToggle_Private_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A598 File Offset: 0x00008798
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 507426, RefRangeEnd = 507452, XrefRangeStart = 507386, XrefRangeEnd = 507426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Space(float pixels)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pixels;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Space_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000A5CC File Offset: 0x000087CC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 507490, RefRangeEnd = 507505, XrefRangeStart = 507452, XrefRangeEnd = 507490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlexibleSpace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A5F4 File Offset: 0x000087F4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 507535, RefRangeEnd = 507554, XrefRangeStart = 507505, XrefRangeEnd = 507535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginHorizontal([Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000A638 File Offset: 0x00008838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507554, XrefRangeEnd = 507576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginHorizontal(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A6A0 File Offset: 0x000088A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 324828, RefRangeEnd = 324835, XrefRangeStart = 324828, XrefRangeEnd = 324835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndHorizontal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507606, RefRangeEnd = 507609, XrefRangeStart = 507576, XrefRangeEnd = 507606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginVertical([Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A70C File Offset: 0x0000890C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507609, XrefRangeEnd = 507631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginVertical(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A774 File Offset: 0x00008974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324843, RefRangeEnd = 324845, XrefRangeStart = 324843, XrefRangeEnd = 324845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndVertical()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndVertical_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000A79C File Offset: 0x0000899C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 507640, RefRangeEnd = 507644, XrefRangeStart = 507631, XrefRangeEnd = 507640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginArea(Rect screenRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507673, RefRangeEnd = 507674, XrefRangeStart = 507644, XrefRangeEnd = 507673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000A828 File Offset: 0x00008A28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 507698, RefRangeEnd = 507702, XrefRangeStart = 507674, XrefRangeEnd = 507698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndArea()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndArea_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A850 File Offset: 0x00008A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507709, RefRangeEnd = 507712, XrefRangeStart = 507702, XrefRangeEnd = 507709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 BeginScrollView(Vector2 scrollPosition, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000A8AC File Offset: 0x00008AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507737, RefRangeEnd = 507738, XrefRangeStart = 507712, XrefRangeEnd = 507737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowHorizontal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowVertical;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(horizontalScrollbar);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verticalScrollbar);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(background);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A960 File Offset: 0x00008B60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507746, RefRangeEnd = 507749, XrefRangeStart = 507738, XrefRangeEnd = 507746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndScrollView()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A988 File Offset: 0x00008B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507749, XrefRangeEnd = 507757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndScrollView(bool handleScrollWheel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleScrollWheel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A9BC File Offset: 0x00008BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 507766, RefRangeEnd = 507768, XrefRangeStart = 507757, XrefRangeEnd = 507766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000AA4C File Offset: 0x00008C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507784, RefRangeEnd = 507785, XrefRangeStart = 507768, XrefRangeEnd = 507784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 507791, RefRangeEnd = 507801, XrefRangeStart = 507785, XrefRangeEnd = 507791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Width(float width)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000AB24 File Offset: 0x00008D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507801, XrefRangeEnd = 507807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption MinWidth(float minWidth)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minWidth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_MinWidth_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000AB64 File Offset: 0x00008D64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 507813, RefRangeEnd = 507817, XrefRangeStart = 507807, XrefRangeEnd = 507813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Height(float height)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 507823, RefRangeEnd = 507846, XrefRangeStart = 507817, XrefRangeEnd = 507823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption ExpandWidth(bool expand)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 507852, RefRangeEnd = 507856, XrefRangeStart = 507846, XrefRangeEnd = 507852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption ExpandHeight(bool expand)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000027CC File Offset: 0x000009CC
		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000027DA File Offset: 0x000009DA
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000027E9 File Offset: 0x000009E9
		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000027F8 File Offset: 0x000009F8
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002806 File Offset: 0x00000A06
		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002814 File Offset: 0x00000A14
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002823 File Offset: 0x00000A23
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002833 File Offset: 0x00000A33
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002843 File Offset: 0x00000A43
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002850 File Offset: 0x00000A50
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000285F File Offset: 0x00000A5F
		public static void BeginVertical(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000286C File Offset: 0x00000A6C
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000287B File Offset: 0x00000A7B
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002889 File Offset: 0x00000A89
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000289F File Offset: 0x00000A9F
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000028B1 File Offset: 0x00000AB1
		public GUILayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000028BA File Offset: 0x00000ABA
		public static void Label(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000028D4 File Offset: 0x00000AD4
		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000028E2 File Offset: 0x00000AE2
		public static void Label(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, GUI.skin.label, options);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000028F7 File Offset: 0x00000AF7
		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002905 File Offset: 0x00000B05
		public static void Label(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002916 File Offset: 0x00000B16
		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002925 File Offset: 0x00000B25
		public static void Label(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, style, options);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002931 File Offset: 0x00000B31
		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002940 File Offset: 0x00000B40
		public static void Box(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), GUI.skin.box, options);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000295A File Offset: 0x00000B5A
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002968 File Offset: 0x00000B68
		public static void Box(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), GUI.skin.box, options);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002982 File Offset: 0x00000B82
		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002990 File Offset: 0x00000B90
		public static void Box(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(content, GUI.skin.box, options);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000029A5 File Offset: 0x00000BA5
		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000029B3 File Offset: 0x00000BB3
		public static void Box(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000029D3 File Offset: 0x00000BD3
		public static void Box(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000029E4 File Offset: 0x00000BE4
		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000AC24 File Offset: 0x00008E24
		public static bool Button(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000029F3 File Offset: 0x00000BF3
		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000AC4C File Offset: 0x00008E4C
		public static bool Button(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002A01 File Offset: 0x00000C01
		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000AC70 File Offset: 0x00008E70
		public static bool Button(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002A0F File Offset: 0x00000C0F
		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000AC90 File Offset: 0x00008E90
		public static bool Button(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002A1E File Offset: 0x00000C1E
		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public static bool Button(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, style, options);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002A2D File Offset: 0x00000C2D
		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000ACCC File Offset: 0x00008ECC
		public static bool RepeatButton(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002A3C File Offset: 0x00000C3C
		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public static bool RepeatButton(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002A4A File Offset: 0x00000C4A
		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public static bool RepeatButton(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002A58 File Offset: 0x00000C58
		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000AD40 File Offset: 0x00008F40
		public static bool RepeatButton(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002A66 File Offset: 0x00000C66
		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000AD60 File Offset: 0x00008F60
		public static bool RepeatButton(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002A75 File Offset: 0x00000C75
		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AD80 File Offset: 0x00008F80
		public static bool RepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, style, options);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002A84 File Offset: 0x00000C84
		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public static bool DoRepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		public static string TextField(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, GUI.skin.textField, options);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002A93 File Offset: 0x00000C93
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public static string TextField(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, GUI.skin.textField, options);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000AE10 File Offset: 0x00009010
		public static string TextField(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, style, options);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000AE2C File Offset: 0x0000902C
		public static string TextField(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, style, options);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002ABF File Offset: 0x00000CBF
		public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000AE48 File Offset: 0x00009048
		public static string PasswordField(string password, char maskChar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, GUI.skin.textField, options);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002ACF File Offset: 0x00000CCF
		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000AE70 File Offset: 0x00009070
		public static string PasswordField(string password, char maskChar, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002ADE File Offset: 0x00000CDE
		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AE98 File Offset: 0x00009098
		public static string PasswordField(string password, char maskChar, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, style, options);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002AEE File Offset: 0x00000CEE
		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000AEB4 File Offset: 0x000090B4
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIContent guicontent = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
			return GUI.PasswordField(GUILayoutUtility.GetRect(guicontent, GUI.skin.textField, options), password, maskChar, maxLength, style);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002AFE File Offset: 0x00000CFE
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public static string TextArea(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, GUI.skin.textArea, options);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002B10 File Offset: 0x00000D10
		public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AF18 File Offset: 0x00009118
		public static string TextArea(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, true, style, options);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002B1F File Offset: 0x00000D1F
		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000AF34 File Offset: 0x00009134
		public static string TextArea(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002B2E File Offset: 0x00000D2E
		public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000AF50 File Offset: 0x00009150
		public static bool Toggle(bool value, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002B3E File Offset: 0x00000D3E
		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000AF7C File Offset: 0x0000917C
		public static bool Toggle(bool value, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, content, GUI.skin.toggle, options);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002B4D File Offset: 0x00000D4D
		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000AFA0 File Offset: 0x000091A0
		public static bool Toggle(bool value, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002B5C File Offset: 0x00000D5C
		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public static int Toolbar(int selected, Il2CppStringArray texts, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002B6C File Offset: 0x00000D6C
		public static int Toolbar(int selected, Il2CppStringArray texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000AFEC File Offset: 0x000091EC
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002B7B File Offset: 0x00000D7B
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000B018 File Offset: 0x00009218
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, GUI.skin.button, options);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002B8A File Offset: 0x00000D8A
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B03C File Offset: 0x0000923C
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, options);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002B99 File Offset: 0x00000D99
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B05C File Offset: 0x0000925C
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, options);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002BA9 File Offset: 0x00000DA9
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000B07C File Offset: 0x0000927C
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, buttonSize, options);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, buttonSize, options);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002BCB File Offset: 0x00000DCB
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B0C4 File Offset: 0x000092C4
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002BDD File Offset: 0x00000DDD
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B0E0 File Offset: 0x000092E0
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, null, style, buttonSize, options);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002BED File Offset: 0x00000DED
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B100 File Offset: 0x00009300
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002BFF File Offset: 0x00000DFF
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002C11 File Offset: 0x00000E11
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002C1E File Offset: 0x00000E1E
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B120 File Offset: 0x00009320
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002C32 File Offset: 0x00000E32
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B14C File Offset: 0x0000934C
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002C42 File Offset: 0x00000E42
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B178 File Offset: 0x00009378
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, GUI.skin.button, options);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002C52 File Offset: 0x00000E52
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002C62 File Offset: 0x00000E62
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002C74 File Offset: 0x00000E74
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002C86 File Offset: 0x00000E86
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, contents, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B210 File Offset: 0x00009410
		public static float HorizontalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002C98 File Offset: 0x00000E98
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B240 File Offset: 0x00009440
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B260 File Offset: 0x00009460
		public static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B290 File Offset: 0x00009490
		public static float VerticalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002CBC File Offset: 0x00000EBC
		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002CCC File Offset: 0x00000ECC
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B310 File Offset: 0x00009510
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B338 File Offset: 0x00009538
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002D06 File Offset: 0x00000F06
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000B368 File Offset: 0x00009568
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002D1A File Offset: 0x00000F1A
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000B390 File Offset: 0x00009590
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002D2C File Offset: 0x00000F2C
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002D40 File Offset: 0x00000F40
		public static void BeginHorizontal(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, style, options);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002D50 File Offset: 0x00000F50
		public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002D5E File Offset: 0x00000F5E
		public static void BeginHorizontal(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002D6F File Offset: 0x00000F6F
		public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002D7E File Offset: 0x00000F7E
		public static void BeginHorizontal(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002D8F File Offset: 0x00000F8F
		public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002D9E File Offset: 0x00000F9E
		public static void BeginVertical(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.none, style, options);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002DAE File Offset: 0x00000FAE
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002DBC File Offset: 0x00000FBC
		public static void BeginVertical(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002DCD File Offset: 0x00000FCD
		public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002DDC File Offset: 0x00000FDC
		public static void BeginVertical(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002DED File Offset: 0x00000FED
		public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002DFC File Offset: 0x00000FFC
		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002E11 File Offset: 0x00001011
		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002E26 File Offset: 0x00001026
		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, content, GUIStyle.none);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002E36 File Offset: 0x00001036
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, style);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002E46 File Offset: 0x00001046
		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), style);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002E57 File Offset: 0x00001057
		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), style);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B3C0 File Offset: 0x000095C0
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002E68 File Offset: 0x00001068
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000B3FC File Offset: 0x000095FC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002E78 File Offset: 0x00001078
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000B424 File Offset: 0x00009624
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
		{
			Il2CppReferenceArray<GUILayoutOption> il2CppReferenceArray = null;
			return GUILayout.BeginScrollView(scrollPosition, style, il2CppReferenceArray);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000B440 File Offset: 0x00009640
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			string name = style.name;
			GUIStyle guistyle = GUI.skin.FindStyle(String.Concat(name, "VerticalScrollbar"));
			bool flag = guistyle == null;
			if (flag)
			{
				guistyle = GUI.skin.verticalScrollbar;
			}
			GUIStyle guistyle2 = GUI.skin.FindStyle(String.Concat(name, "HorizontalScrollbar"));
			bool flag2 = guistyle2 == null;
			if (flag2)
			{
				guistyle2 = GUI.skin.horizontalScrollbar;
			}
			return GUILayout.BeginScrollView(scrollPosition, false, false, guistyle2, guistyle, style, options);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002E88 File Offset: 0x00001088
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000B4BC File Offset: 0x000096BC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002E97 File Offset: 0x00001097
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000B4E8 File Offset: 0x000096E8
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002EAB File Offset: 0x000010AB
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000B514 File Offset: 0x00009714
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, GUI.skin.window, options);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002EBD File Offset: 0x000010BD
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000B53C File Offset: 0x0000973C
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002ECF File Offset: 0x000010CF
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000B560 File Offset: 0x00009760
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002EE3 File Offset: 0x000010E3
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000B584 File Offset: 0x00009784
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, style, options);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002EF7 File Offset: 0x000010F7
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000B5A4 File Offset: 0x000097A4
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxWidth, maxWidth);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minHeight, minHeight);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxHeight, maxHeight);
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_DoBox_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_TextArea_Public_Static_String_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_DoTextField_Private_Static_String_String_Int32_Boolean_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_String_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_DoToggle_Private_Static_Boolean_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Space_Public_Static_Void_Single_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_EndVertical_Public_Static_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_EndArea_Public_Static_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_MinWidth_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0;

		// Token: 0x02000069 RID: 105
		public sealed class LayoutedWindow : Object
		{
			// Token: 0x060006A2 RID: 1698 RVA: 0x000181EC File Offset: 0x000163EC
			// Note: this type is marked as 'beforefieldinit'.
			static LayoutedWindow()
			{
				Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, "LayoutedWindow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr);
				GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, "m_Func");
				GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, "m_ScreenRect");
				GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, "m_Options");
				GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, "m_Style");
				GUILayout.LayoutedWindow.NativeMethodInfoPtr__ctor_Internal_Void_WindowFunction_Rect_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, 100663468);
				GUILayout.LayoutedWindow.NativeMethodInfoPtr_DoWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr, 100663469);
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x00018290 File Offset: 0x00016490
			[CallerCount(0)]
			public unsafe LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options, GUIStyle style)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayout.LayoutedWindow>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.LayoutedWindow.NativeMethodInfoPtr__ctor_Internal_Void_WindowFunction_Rect_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00018324 File Offset: 0x00016524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507135, XrefRangeEnd = 507149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DoWindow(int windowID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref windowID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.LayoutedWindow.NativeMethodInfoPtr_DoWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00004846 File Offset: 0x00002A46
			public LayoutedWindow(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00018364 File Offset: 0x00016564
			// (set) Token: 0x060006A7 RID: 1703 RVA: 0x0000484F File Offset: 0x00002A4F
			public unsafe GUI.WindowFunction m_Func
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Func);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUI.WindowFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Func), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00018394 File Offset: 0x00016594
			// (set) Token: 0x060006A9 RID: 1705 RVA: 0x0000486E File Offset: 0x00002A6E
			public unsafe Rect m_ScreenRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_ScreenRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_ScreenRect)) = value;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060006AA RID: 1706 RVA: 0x000183BC File Offset: 0x000165BC
			// (set) Token: 0x060006AB RID: 1707 RVA: 0x00004889 File Offset: 0x00002A89
			public unsafe Il2CppReferenceArray<GUILayoutOption> m_Options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUILayoutOption>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060006AC RID: 1708 RVA: 0x000183EC File Offset: 0x000165EC
			// (set) Token: 0x060006AD RID: 1709 RVA: 0x000048A8 File Offset: 0x00002AA8
			public unsafe GUIStyle m_Style
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Style);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayout.LayoutedWindow.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003C6 RID: 966
			private static readonly IntPtr NativeFieldInfoPtr_m_Func;

			// Token: 0x040003C7 RID: 967
			private static readonly IntPtr NativeFieldInfoPtr_m_ScreenRect;

			// Token: 0x040003C8 RID: 968
			private static readonly IntPtr NativeFieldInfoPtr_m_Options;

			// Token: 0x040003C9 RID: 969
			private static readonly IntPtr NativeFieldInfoPtr_m_Style;

			// Token: 0x040003CA RID: 970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WindowFunction_Rect_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_GUIStyle_0;

			// Token: 0x040003CB RID: 971
			private static readonly IntPtr NativeMethodInfoPtr_DoWindow_Public_Void_Int32_0;
		}

		// Token: 0x0200006A RID: 106
		public class HorizontalScope : GUI.Scope
		{
		}

		// Token: 0x0200006B RID: 107
		public class VerticalScope : GUI.Scope
		{
		}

		// Token: 0x0200006C RID: 108
		public class AreaScope : GUI.Scope
		{
		}

		// Token: 0x0200006D RID: 109
		public class ScrollViewScope : GUI.Scope
		{
		}
	}
}
