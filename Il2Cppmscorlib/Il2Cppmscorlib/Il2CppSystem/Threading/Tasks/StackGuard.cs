using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AC RID: 684
	public class StackGuard : Object
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x000EFB74 File Offset: 0x000EDD74
		// Note: this type is marked as 'beforefieldinit'.
		static StackGuard()
		{
			Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StackGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
			StackGuard.NativeFieldInfoPtr_m_inliningDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "m_inliningDepth");
			StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "MAX_UNCHECKED_INLINING_DEPTH");
			StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670800);
			StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670801);
			StackGuard.NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670802);
			StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670803);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000EFC1C File Offset: 0x000EDE1C
		[CallerCount(0)]
		public unsafe bool TryBeginInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000EFC58 File Offset: 0x000EDE58
		[CallerCount(0)]
		public unsafe void EndInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000EFC8C File Offset: 0x000EDE8C
		[CallerCount(0)]
		public unsafe bool CheckForSufficientStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000EFCC8 File Offset: 0x000EDEC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackGuard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x0001041A File Offset: 0x0000E61A
		public StackGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000EFD04 File Offset: 0x000EDF04
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00010423 File Offset: 0x0000E623
		public unsafe int m_inliningDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth)) = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000EFD2C File Offset: 0x000EDF2C
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x0001043E File Offset: 0x0000E63E
		public unsafe static int MAX_UNCHECKED_INLINING_DEPTH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH, (void*)(&value));
			}
		}

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeFieldInfoPtr_m_inliningDepth;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_EndInliningScope_Internal_Void_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
