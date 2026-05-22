using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Collections.Generic
{
	// Token: 0x020001E7 RID: 487
	public class UndoManager : Object
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		// Note: this type is marked as 'beforefieldinit'.
		static UndoManager()
		{
			Il2CppClassPointerStore<UndoManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Generic", "UndoManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoManager>.NativeClassPtr);
			UndoManager.NativeFieldInfoPtr_undoStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, "undoStack");
			UndoManager.NativeFieldInfoPtr_redoStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, "redoStack");
			UndoManager.NativeMethodInfoPtr_Execute_Public_Void_ICommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666940);
			UndoManager.NativeMethodInfoPtr_Undo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666941);
			UndoManager.NativeMethodInfoPtr_Redo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666942);
			UndoManager.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666943);
			UndoManager.NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666944);
			UndoManager.NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666945);
			UndoManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoManager>.NativeClassPtr, 100666946);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0006F4BC File Offset: 0x0006D6BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 20300, RefRangeEnd = 20310, XrefRangeStart = 20292, XrefRangeEnd = 20300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(ICommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_Execute_Public_Void_ICommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0006F500 File Offset: 0x0006D700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20320, RefRangeEnd = 20321, XrefRangeStart = 20310, XrefRangeEnd = 20320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_Undo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0006F53C File Offset: 0x0006D73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20331, RefRangeEnd = 20332, XrefRangeStart = 20321, XrefRangeEnd = 20331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_Redo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0006F578 File Offset: 0x0006D778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20335, RefRangeEnd = 20336, XrefRangeStart = 20332, XrefRangeEnd = 20335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0006F5AC File Offset: 0x0006D7AC
		public unsafe int UndoCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20336, XrefRangeEnd = 20337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		public unsafe int RedoCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20337, XrefRangeEnd = 20338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0006F624 File Offset: 0x0006D824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20346, RefRangeEnd = 20349, XrefRangeStart = 20338, XrefRangeEnd = 20346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00009DC3 File Offset: 0x00007FC3
		public UndoManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0006F660 File Offset: 0x0006D860
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00009DCC File Offset: 0x00007FCC
		public unsafe Stack<ICommand> undoStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoManager.NativeFieldInfoPtr_undoStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ICommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoManager.NativeFieldInfoPtr_undoStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0006F690 File Offset: 0x0006D890
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00009DEB File Offset: 0x00007FEB
		public unsafe Stack<ICommand> redoStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoManager.NativeFieldInfoPtr_redoStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ICommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoManager.NativeFieldInfoPtr_redoStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_undoStack;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_redoStack;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_ICommand_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Boolean_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Boolean_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
