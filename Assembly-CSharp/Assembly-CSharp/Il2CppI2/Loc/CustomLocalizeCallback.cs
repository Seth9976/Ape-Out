using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025C RID: 604
	public class CustomLocalizeCallback : MonoBehaviour
	{
		// Token: 0x060045FC RID: 17916 RVA: 0x001053F8 File Offset: 0x001035F8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomLocalizeCallback()
		{
			Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "CustomLocalizeCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr);
			CustomLocalizeCallback.NativeFieldInfoPtr__OnLocalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr, "_OnLocalize");
			CustomLocalizeCallback.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr, 100670363);
			CustomLocalizeCallback.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr, 100670364);
			CustomLocalizeCallback.NativeMethodInfoPtr_OnLocalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr, 100670365);
			CustomLocalizeCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr, 100670366);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0010548C File Offset: 0x0010368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114204, XrefRangeEnd = 114221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLocalizeCallback.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x001054C0 File Offset: 0x001036C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114221, XrefRangeEnd = 114232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLocalizeCallback.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x001054F4 File Offset: 0x001036F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114232, XrefRangeEnd = 114234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLocalizeCallback.NativeMethodInfoPtr_OnLocalize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00105528 File Offset: 0x00103728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114234, XrefRangeEnd = 114241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomLocalizeCallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomLocalizeCallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLocalizeCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00029BD5 File Offset: 0x00027DD5
		public CustomLocalizeCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x00105564 File Offset: 0x00103764
		// (set) Token: 0x06004603 RID: 17923 RVA: 0x00029BDE File Offset: 0x00027DDE
		public unsafe UnityEvent _OnLocalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLocalizeCallback.NativeFieldInfoPtr__OnLocalize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLocalizeCallback.NativeFieldInfoPtr__OnLocalize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeFieldInfoPtr__OnLocalize;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalize_Public_Void_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
