using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public class TMP_InputValidator : ScriptableObject
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_InputValidator()
		{
			Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_InputValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr);
			TMP_InputValidator.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr, 100663955);
			TMP_InputValidator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr, 100663956);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001C010 File Offset: 0x0001A210
		[CallerCount(0)]
		public unsafe virtual char Validate(ref string text, ref int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputValidator.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			text = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001C094 File Offset: 0x0001A294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_InputValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputValidator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000045F8 File Offset: 0x000027F8
		public TMP_InputValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
