using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025E RID: 606
	public static class I2Utils : global::Il2CppSystem.Object
	{
		// Token: 0x06004608 RID: 17928 RVA: 0x00105664 File Offset: 0x00103864
		// Note: this type is marked as 'beforefieldinit'.
		static I2Utils()
		{
			Il2CppClassPointerStore<I2Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "I2Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<I2Utils>.NativeClassPtr);
			I2Utils.NativeFieldInfoPtr_ValidChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, "ValidChars");
			I2Utils.NativeFieldInfoPtr_NumberChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, "NumberChars");
			I2Utils.NativeFieldInfoPtr_ValidNameSymbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, "ValidNameSymbols");
			I2Utils.NativeMethodInfoPtr_ReverseText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670372);
			I2Utils.NativeMethodInfoPtr_RemoveNonASCII_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670373);
			I2Utils.NativeMethodInfoPtr_GetValidTermName_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670374);
			I2Utils.NativeMethodInfoPtr_SplitLine_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670375);
			I2Utils.NativeMethodInfoPtr_FindNextTag_Public_Static_Boolean_String_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670376);
			I2Utils.NativeMethodInfoPtr_RemoveTags_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670377);
			I2Utils.NativeMethodInfoPtr_RemoveResourcesPath_Public_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670378);
			I2Utils.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670379);
			I2Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670380);
			I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670381);
			I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_Scene_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670382);
			I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670383);
			I2Utils.NativeMethodInfoPtr_FindInParents_Public_Static_H_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670384);
			I2Utils.NativeMethodInfoPtr_GetCaptureMatch_Public_Static_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670385);
			I2Utils.NativeMethodInfoPtr_SendWebRequest_Public_Static_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670386);
			I2Utils.NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, 100670387);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00105810 File Offset: 0x00103A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114283, RefRangeEnd = 114285, XrefRangeStart = 114270, XrefRangeEnd = 114283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReverseText(string source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_ReverseText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x0010584C File Offset: 0x00103A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114302, RefRangeEnd = 114303, XrefRangeStart = 114285, XrefRangeEnd = 114302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_RemoveNonASCII_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00105898 File Offset: 0x00103A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114312, RefRangeEnd = 114315, XrefRangeStart = 114303, XrefRangeEnd = 114312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetValidTermName(string text, bool allowCategory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCategory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_GetValidTermName_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001058E4 File Offset: 0x00103AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114349, RefRangeEnd = 114350, XrefRangeStart = 114315, XrefRangeEnd = 114349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SplitLine(string line, int maxCharacters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCharacters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_SplitLine_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00105930 File Offset: 0x00103B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114350, RefRangeEnd = 114352, XrefRangeStart = 114350, XrefRangeEnd = 114350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_FindNextTag_Public_Static_Boolean_String_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x0010599C File Offset: 0x00103B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114352, XrefRangeEnd = 114360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveTags(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_RemoveTags_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x001059D8 File Offset: 0x00103BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114360, XrefRangeEnd = 114408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveResourcesPath(ref string sPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(sPath);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_RemoveResourcesPath_Public_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				sPath = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00105A28 File Offset: 0x00103C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114410, RefRangeEnd = 114413, XrefRangeStart = 114408, XrefRangeEnd = 114410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPlaying()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00105A58 File Offset: 0x00103C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114436, RefRangeEnd = 114437, XrefRangeStart = 114413, XrefRangeEnd = 114436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPath(this Transform tr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00105A94 File Offset: 0x00103C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114437, XrefRangeEnd = 114442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindObject(string objectPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00105AD8 File Offset: 0x00103CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114460, RefRangeEnd = 114461, XrefRangeStart = 114442, XrefRangeEnd = 114460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindObject(Scene scene, string objectPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_Scene_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00105B2C File Offset: 0x00103D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114480, RefRangeEnd = 114482, XrefRangeStart = 114461, XrefRangeEnd = 114480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindObject(Transform root, string objectPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_FindObject_Public_Static_Transform_Transform_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00105B84 File Offset: 0x00103D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114482, XrefRangeEnd = 114512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static H FindInParents<H>(Transform tr) where H : Component
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.MethodInfoStoreGeneric_FindInParents_Public_Static_H_Transform_0<H>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<H>(intPtr, false, true);
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00105BC4 File Offset: 0x00103DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114515, RefRangeEnd = 114517, XrefRangeStart = 114512, XrefRangeEnd = 114515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCaptureMatch(Match match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_GetCaptureMatch_Public_Static_String_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x00105C00 File Offset: 0x00103E00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 114519, RefRangeEnd = 114525, XrefRangeStart = 114517, XrefRangeEnd = 114519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendWebRequest(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_SendWebRequest_Public_Static_Void_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00105C38 File Offset: 0x00103E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114525, RefRangeEnd = 114527, XrefRangeStart = 114525, XrefRangeEnd = 114525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass3_0_0(int start, int end, ref I2Utils.__c__DisplayClass3_0 A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass3_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00029C06 File Offset: 0x00027E06
		public I2Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x00105C90 File Offset: 0x00103E90
		// (set) Token: 0x0600461B RID: 17947 RVA: 0x00029C0F File Offset: 0x00027E0F
		public unsafe static string ValidChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(I2Utils.NativeFieldInfoPtr_ValidChars, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(I2Utils.NativeFieldInfoPtr_ValidChars, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x00105CB0 File Offset: 0x00103EB0
		// (set) Token: 0x0600461D RID: 17949 RVA: 0x00029C21 File Offset: 0x00027E21
		public unsafe static string NumberChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(I2Utils.NativeFieldInfoPtr_NumberChars, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(I2Utils.NativeFieldInfoPtr_NumberChars, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x00105CD0 File Offset: 0x00103ED0
		// (set) Token: 0x0600461F RID: 17951 RVA: 0x00029C33 File Offset: 0x00027E33
		public unsafe static string ValidNameSymbols
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(I2Utils.NativeFieldInfoPtr_ValidNameSymbols, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(I2Utils.NativeFieldInfoPtr_ValidNameSymbols, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeFieldInfoPtr_ValidChars;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeFieldInfoPtr_NumberChars;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeFieldInfoPtr_ValidNameSymbols;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_ReverseText_Public_Static_String_String_0;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNonASCII_Public_Static_String_String_Boolean_0;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_GetValidTermName_Public_Static_String_String_Boolean_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_SplitLine_Public_Static_String_String_Int32_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_FindNextTag_Public_Static_Boolean_String_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTags_Public_Static_String_String_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_RemoveResourcesPath_Public_Static_Boolean_byref_String_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_FindObject_Public_Static_Transform_String_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr_FindObject_Public_Static_Transform_Scene_String_0;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeMethodInfoPtr_FindObject_Public_Static_Transform_Transform_String_0;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeMethodInfoPtr_FindInParents_Public_Static_H_Transform_0;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeMethodInfoPtr_GetCaptureMatch_Public_Static_String_Match_0;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Public_Static_Void_UnityWebRequest_0;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass3_0_0;

		// Token: 0x020003D8 RID: 984
		[ObfuscatedName("I2.Loc.I2Utils+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : ValueType
		{
			// Token: 0x06005A83 RID: 23171 RVA: 0x00147030 File Offset: 0x00145230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<I2Utils.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<I2Utils.__c__DisplayClass3_0>.NativeClassPtr);
				I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils.__c__DisplayClass3_0>.NativeClassPtr, "output");
				I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils.__c__DisplayClass3_0>.NativeClassPtr, "source");
			}

			// Token: 0x06005A84 RID: 23172 RVA: 0x00033B1A File Offset: 0x00031D1A
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005A85 RID: 23173 RVA: 0x00033B23 File Offset: 0x00031D23
			public __c__DisplayClass3_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<I2Utils.__c__DisplayClass3_0>.NativeClassPtr))
			{
			}

			// Token: 0x170020F3 RID: 8435
			// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00147084 File Offset: 0x00145284
			// (set) Token: 0x06005A87 RID: 23175 RVA: 0x00033B35 File Offset: 0x00031D35
			public unsafe Il2CppStructArray<char> output
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_output);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020F4 RID: 8436
			// (get) Token: 0x06005A88 RID: 23176 RVA: 0x001470B4 File Offset: 0x001452B4
			// (set) Token: 0x06005A89 RID: 23177 RVA: 0x00033B54 File Offset: 0x00031D54
			public unsafe string source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_source);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(I2Utils.__c__DisplayClass3_0.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003C21 RID: 15393
			private static readonly IntPtr NativeFieldInfoPtr_output;

			// Token: 0x04003C22 RID: 15394
			private static readonly IntPtr NativeFieldInfoPtr_source;
		}

		// Token: 0x020003D9 RID: 985
		[ObfuscatedName("I2.Loc.I2Utils+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06005A8A RID: 23178 RVA: 0x001470DC File Offset: 0x001452DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<I2Utils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr);
				I2Utils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr, "<>9");
				I2Utils.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr, "<>9__6_0");
				I2Utils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr, 100670389);
				I2Utils.__c.NativeMethodInfoPtr__SplitLine_b__6_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr, 100670390);
			}

			// Token: 0x06005A8B RID: 23179 RVA: 0x00147158 File Offset: 0x00145358
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<I2Utils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A8C RID: 23180 RVA: 0x00147194 File Offset: 0x00145394
			[CallerCount(0)]
			public unsafe bool _SplitLine_b__6_0(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2Utils.__c.NativeMethodInfoPtr__SplitLine_b__6_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A8D RID: 23181 RVA: 0x00033B73 File Offset: 0x00031D73
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020F5 RID: 8437
			// (get) Token: 0x06005A8E RID: 23182 RVA: 0x001471E0 File Offset: 0x001453E0
			// (set) Token: 0x06005A8F RID: 23183 RVA: 0x00033B7C File Offset: 0x00031D7C
			public unsafe static I2Utils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(I2Utils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<I2Utils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(I2Utils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020F6 RID: 8438
			// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00147208 File Offset: 0x00145408
			// (set) Token: 0x06005A91 RID: 23185 RVA: 0x00033B8E File Offset: 0x00031D8E
			public unsafe static Func<char, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(I2Utils.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(I2Utils.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C23 RID: 15395
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C24 RID: 15396
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04003C25 RID: 15397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C26 RID: 15398
			private static readonly IntPtr NativeMethodInfoPtr__SplitLine_b__6_0_Internal_Boolean_Char_0;
		}

		// Token: 0x020003DA RID: 986
		private sealed class MethodInfoStoreGeneric_FindInParents_Public_Static_H_Transform_0<H>
		{
			// Token: 0x04003C27 RID: 15399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(I2Utils.NativeMethodInfoPtr_FindInParents_Public_Static_H_Transform_0, Il2CppClassPointerStore<I2Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<H>.NativeClassPtr)) }))));
		}
	}
}
