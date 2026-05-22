using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x02000197 RID: 407
	public class IntPtrWrapper : Object
	{
		// Token: 0x06002ADE RID: 10974 RVA: 0x000D5EEC File Offset: 0x000D40EC
		// Note: this type is marked as 'beforefieldinit'.
		static IntPtrWrapper()
		{
			Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IntPtrWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr);
			IntPtrWrapper.NativeFieldInfoPtr_yULnCoonCNYSdxDObEtDhvoFTEm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr, "yULnCoonCNYSdxDObEtDhvoFTEm");
			IntPtrWrapper.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr, 100674430);
			IntPtrWrapper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr, 100674432);
			IntPtrWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_IntPtrWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtrWrapper>.NativeClassPtr, 100674433);
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x000D5F6C File Offset: 0x000D416C
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322947, XrefRangeEnd = 322948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtrWrapper.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000D5FA8 File Offset: 0x000D41A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322948, XrefRangeEnd = 322949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtrWrapper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000D5FDC File Offset: 0x000D41DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322949, XrefRangeEnd = 322950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator IntPtr(IntPtrWrapper obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtrWrapper.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_IntPtrWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00010182 File Offset: 0x0000E382
		public IntPtrWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000D6020 File Offset: 0x000D4220
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x0001018B File Offset: 0x0000E38B
		public unsafe IntPtr yULnCoonCNYSdxDObEtDhvoFTEm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPtrWrapper.NativeFieldInfoPtr_yULnCoonCNYSdxDObEtDhvoFTEm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPtrWrapper.NativeFieldInfoPtr_yULnCoonCNYSdxDObEtDhvoFTEm)) = value;
			}
		}

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeFieldInfoPtr_yULnCoonCNYSdxDObEtDhvoFTEm;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_IntPtrWrapper_0;
	}
}
