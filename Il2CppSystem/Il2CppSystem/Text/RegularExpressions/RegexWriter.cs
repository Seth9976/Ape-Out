using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000067 RID: 103
	public sealed class RegexWriter : Object
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x0002CA00 File Offset: 0x0002AC00
		// Note: this type is marked as 'beforefieldinit'.
		static RegexWriter()
		{
			Il2CppClassPointerStore<RegexWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr);
			RegexWriter.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_intStack");
			RegexWriter.NativeFieldInfoPtr__depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_depth");
			RegexWriter.NativeFieldInfoPtr__emitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_emitted");
			RegexWriter.NativeFieldInfoPtr__curpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_curpos");
			RegexWriter.NativeFieldInfoPtr__stringhash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringhash");
			RegexWriter.NativeFieldInfoPtr__stringtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringtable");
			RegexWriter.NativeFieldInfoPtr__counting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_counting");
			RegexWriter.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_count");
			RegexWriter.NativeFieldInfoPtr__trackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_trackcount");
			RegexWriter.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_caps");
			RegexWriter.NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664382);
			RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664383);
			RegexWriter.NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664384);
			RegexWriter.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664385);
			RegexWriter.NativeMethodInfoPtr_PopInt_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664386);
			RegexWriter.NativeMethodInfoPtr_CurPos_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664387);
			RegexWriter.NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664388);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664389);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664390);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664391);
			RegexWriter.NativeMethodInfoPtr_StringCode_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664392);
			RegexWriter.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664393);
			RegexWriter.NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664394);
			RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664395);
			RegexWriter.NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664396);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0002CC24 File Offset: 0x0002AE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372304, XrefRangeEnd = 372310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCode Write(RegexTree t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0002CC68 File Offset: 0x0002AE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372326, RefRangeEnd = 372327, XrefRangeStart = 372310, XrefRangeEnd = 372326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372331, RefRangeEnd = 372333, XrefRangeStart = 372327, XrefRangeEnd = 372331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInt(int I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		[CallerCount(0)]
		public unsafe bool EmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0002CD20 File Offset: 0x0002AF20
		[CallerCount(0)]
		public unsafe int PopInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PopInt_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		[CallerCount(0)]
		public unsafe int CurPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_CurPos_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0002CD98 File Offset: 0x0002AF98
		[CallerCount(0)]
		public unsafe void PatchJump(int Offset, int jumpDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372333, RefRangeEnd = 372335, XrefRangeStart = 372333, XrefRangeEnd = 372333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0002CE24 File Offset: 0x0002B024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372335, RefRangeEnd = 372337, XrefRangeStart = 372335, XrefRangeEnd = 372335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002CE70 File Offset: 0x0002B070
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372337, RefRangeEnd = 372341, XrefRangeStart = 372337, XrefRangeEnd = 372337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1, int opd2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002CECC File Offset: 0x0002B0CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372352, RefRangeEnd = 372355, XrefRangeStart = 372341, XrefRangeEnd = 372352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int StringCode(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_StringCode_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0002CF1C File Offset: 0x0002B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372355, XrefRangeEnd = 372359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException MakeException(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002CF6C File Offset: 0x0002B16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372360, RefRangeEnd = 372361, XrefRangeStart = 372359, XrefRangeEnd = 372360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MapCapnum(int capnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372407, RefRangeEnd = 372408, XrefRangeStart = 372361, XrefRangeEnd = 372407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0002D008 File Offset: 0x0002B208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372426, RefRangeEnd = 372429, XrefRangeStart = 372408, XrefRangeEnd = 372426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitFragment(int nodetype, RegexNode node, int CurIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CurIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00004D53 File Offset: 0x00002F53
		public RegexWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0002D068 File Offset: 0x0002B268
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00004D5C File Offset: 0x00002F5C
		public unsafe Il2CppStructArray<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0002D098 File Offset: 0x0002B298
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00004D7B File Offset: 0x00002F7B
		public unsafe int _depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__depth)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00004D96 File Offset: 0x00002F96
		public unsafe Il2CppStructArray<int> _emitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00004DB5 File Offset: 0x00002FB5
		public unsafe int _curpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__curpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__curpos)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0002D118 File Offset: 0x0002B318
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public unsafe Dictionary<string, int> _stringhash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringhash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringhash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0002D148 File Offset: 0x0002B348
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00004DEF File Offset: 0x00002FEF
		public unsafe List<string> _stringtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0002D178 File Offset: 0x0002B378
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00004E0E File Offset: 0x0000300E
		public unsafe bool _counting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__counting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__counting)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00004E29 File Offset: 0x00003029
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00004E44 File Offset: 0x00003044
		public unsafe int _trackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackcount)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0002D1F0 File Offset: 0x0002B3F0
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00004E5F File Offset: 0x0000305F
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr__depth;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr__emitted;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr__curpos;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr__stringhash;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr__stringtable;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr__counting;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__trackcount;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_PopInt_Internal_Int32_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_CurPos_Internal_Int32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_StringCode_Internal_Int32_String_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0;
	}
}
