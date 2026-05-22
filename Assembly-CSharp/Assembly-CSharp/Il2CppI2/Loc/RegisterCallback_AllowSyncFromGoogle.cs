using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000269 RID: 617
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x00106BF4 File Offset: 0x00104DF4
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterCallback_AllowSyncFromGoogle()
		{
			Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "RegisterCallback_AllowSyncFromGoogle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr);
			RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr, 100670421);
			RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr, 100670422);
			RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr, 100670423);
			RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_AllowSyncFromGoogle_Public_Virtual_New_Boolean_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr, 100670424);
			RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr, 100670425);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00106C88 File Offset: 0x00104E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115197, XrefRangeEnd = 115205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00106CBC File Offset: 0x00104EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00106CF0 File Offset: 0x00104EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115213, XrefRangeEnd = 115217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x00106D24 File Offset: 0x00104F24
		[CallerCount(0)]
		public unsafe virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr_AllowSyncFromGoogle_Public_Virtual_New_Boolean_LanguageSourceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00106D7C File Offset: 0x00104F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterCallback_AllowSyncFromGoogle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterCallback_AllowSyncFromGoogle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCallback_AllowSyncFromGoogle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00029E3F File Offset: 0x0002803F
		public RegisterCallback_AllowSyncFromGoogle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr_AllowSyncFromGoogle_Public_Virtual_New_Boolean_LanguageSourceData_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
