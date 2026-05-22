using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200026E RID: 622
	public class SetLanguageDropdown : MonoBehaviour
	{
		// Token: 0x06004696 RID: 18070 RVA: 0x0010755C File Offset: 0x0010575C
		// Note: this type is marked as 'beforefieldinit'.
		static SetLanguageDropdown()
		{
			Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "SetLanguageDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr);
			SetLanguageDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr, 100670443);
			SetLanguageDropdown.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr, 100670444);
			SetLanguageDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr, 100670445);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x001075C8 File Offset: 0x001057C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115540, XrefRangeEnd = 115586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguageDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x001075FC File Offset: 0x001057FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115586, XrefRangeEnd = 115598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguageDropdown.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x0010763C File Offset: 0x0010583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLanguageDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLanguageDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguageDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00029F29 File Offset: 0x00028129
		public SetLanguageDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
