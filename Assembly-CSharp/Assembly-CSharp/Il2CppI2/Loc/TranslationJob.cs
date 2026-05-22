using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000232 RID: 562
	public class TranslationJob : Object
	{
		// Token: 0x060042F6 RID: 17142 RVA: 0x000F9124 File Offset: 0x000F7324
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob()
		{
			Il2CppClassPointerStore<TranslationJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr);
			TranslationJob.NativeFieldInfoPtr_mJobState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr, "mJobState");
			TranslationJob.NativeMethodInfoPtr_GetState_Public_Virtual_New_eJobState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr, 100669890);
			TranslationJob.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr, 100669891);
			TranslationJob.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr, 100669892);
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x000F91A4 File Offset: 0x000F73A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TranslationJob.eJobState GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob.NativeMethodInfoPtr_GetState_Public_Virtual_New_eJobState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x000F91EC File Offset: 0x000F73EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x000F9228 File Offset: 0x000F7428
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00028A79 File Offset: 0x00026C79
		public TranslationJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x000F9264 File Offset: 0x000F7464
		// (set) Token: 0x060042FC RID: 17148 RVA: 0x00028A82 File Offset: 0x00026C82
		public unsafe TranslationJob.eJobState mJobState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob.NativeFieldInfoPtr_mJobState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob.NativeFieldInfoPtr_mJobState)) = value;
			}
		}

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeFieldInfoPtr_mJobState;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_New_eJobState_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003BB RID: 955
		[OriginalName("Assembly-CSharp.dll", "", "eJobState")]
		public enum eJobState
		{
			// Token: 0x04003B96 RID: 15254
			Running,
			// Token: 0x04003B97 RID: 15255
			Succeeded,
			// Token: 0x04003B98 RID: 15256
			Failed
		}
	}
}
