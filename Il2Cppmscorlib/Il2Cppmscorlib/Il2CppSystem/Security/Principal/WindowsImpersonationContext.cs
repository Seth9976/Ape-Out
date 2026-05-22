using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002D2 RID: 722
	public class WindowsImpersonationContext : Object
	{
		// Token: 0x060030CD RID: 12493 RVA: 0x000F62E0 File Offset: 0x000F44E0
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsImpersonationContext()
		{
			Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsImpersonationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr);
			WindowsImpersonationContext.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "_token");
			WindowsImpersonationContext.NativeFieldInfoPtr_undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "undo");
			WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671046);
			WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671047);
			WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671048);
			WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671049);
			WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671050);
			WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100671051);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000F63B0 File Offset: 0x000F45B0
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000F63E4 File Offset: 0x000F45E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208674, XrefRangeEnd = 208676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000F6418 File Offset: 0x000F4618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208676, XrefRangeEnd = 208677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000F6458 File Offset: 0x000F4658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208677, XrefRangeEnd = 208678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr DuplicateToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000F6498 File Offset: 0x000F4698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208678, XrefRangeEnd = 208679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCurrentToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000F64D8 File Offset: 0x000F46D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208680, RefRangeEnd = 208681, XrefRangeStart = 208679, XrefRangeEnd = 208680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RevertToSelf()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00010F8D File Offset: 0x0000F18D
		public WindowsImpersonationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x000F6508 File Offset: 0x000F4708
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x00010F96 File Offset: 0x0000F196
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x000F6530 File Offset: 0x000F4730
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00010FB1 File Offset: 0x0000F1B1
		public unsafe bool undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo)) = value;
			}
		}

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeFieldInfoPtr_undo;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0;
	}
}
