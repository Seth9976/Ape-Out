using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000060 RID: 96
	public sealed class RegexNode : Object
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00028CF0 File Offset: 0x00026EF0
		// Note: this type is marked as 'beforefieldinit'.
		static RegexNode()
		{
			Il2CppClassPointerStore<RegexNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexNode>.NativeClassPtr);
			RegexNode.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_type");
			RegexNode.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_children");
			RegexNode.NativeFieldInfoPtr__str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_str");
			RegexNode.NativeFieldInfoPtr__ch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_ch");
			RegexNode.NativeFieldInfoPtr__m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_m");
			RegexNode.NativeFieldInfoPtr__n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_n");
			RegexNode.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_options");
			RegexNode.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_next");
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664251);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664252);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664253);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664254);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664255);
			RegexNode.NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664256);
			RegexNode.NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664257);
			RegexNode.NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664258);
			RegexNode.NativeMethodInfoPtr_Reduce_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664259);
			RegexNode.NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664260);
			RegexNode.NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664261);
			RegexNode.NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664262);
			RegexNode.NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664263);
			RegexNode.NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664264);
			RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664265);
			RegexNode.NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664266);
			RegexNode.NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664267);
			RegexNode.NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664268);
			RegexNode.NativeMethodInfoPtr_ChildCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664269);
			RegexNode.NativeMethodInfoPtr_Type_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664270);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00028F50 File Offset: 0x00027150
		[CallerCount(0)]
		public unsafe RegexNode(int type, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00028FA8 File Offset: 0x000271A8
		[CallerCount(0)]
		public unsafe RegexNode(int type, RegexOptions options, char ch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0002900C File Offset: 0x0002720C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371163, RefRangeEnd = 371164, XrefRangeStart = 371163, XrefRangeEnd = 371163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00029074 File Offset: 0x00027274
		[CallerCount(0)]
		public unsafe RegexNode(int type, RegexOptions options, int m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000290D8 File Offset: 0x000272D8
		[CallerCount(0)]
		public unsafe RegexNode(int type, RegexOptions options, int m, int n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0002914C File Offset: 0x0002734C
		[CallerCount(0)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00029188 File Offset: 0x00027388
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371167, RefRangeEnd = 371170, XrefRangeStart = 371164, XrefRangeEnd = 371167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReverseLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000291C8 File Offset: 0x000273C8
		[CallerCount(0)]
		public unsafe void MakeRep(int type, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00029224 File Offset: 0x00027424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371170, XrefRangeEnd = 371171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Reduce_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00029264 File Offset: 0x00027464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371174, RefRangeEnd = 371176, XrefRangeStart = 371171, XrefRangeEnd = 371174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode StripEnation(int emptyType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emptyType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000292B0 File Offset: 0x000274B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371176, XrefRangeEnd = 371178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000292F0 File Offset: 0x000274F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371187, RefRangeEnd = 371188, XrefRangeStart = 371178, XrefRangeEnd = 371187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceRep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00029330 File Offset: 0x00027530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371196, RefRangeEnd = 371197, XrefRangeStart = 371188, XrefRangeEnd = 371196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00029370 File Offset: 0x00027570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371242, RefRangeEnd = 371244, XrefRangeStart = 371197, XrefRangeEnd = 371242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceAlternation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000293B0 File Offset: 0x000275B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371281, RefRangeEnd = 371282, XrefRangeStart = 371244, XrefRangeEnd = 371281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceConcatenation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000293F0 File Offset: 0x000275F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371282, XrefRangeEnd = 371290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00029458 File Offset: 0x00027658
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 371310, RefRangeEnd = 371320, XrefRangeStart = 371290, XrefRangeEnd = 371310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(RegexNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0002949C File Offset: 0x0002769C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371321, RefRangeEnd = 371322, XrefRangeStart = 371320, XrefRangeEnd = 371321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Child(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000294E8 File Offset: 0x000276E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371322, XrefRangeEnd = 371323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ChildCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ChildCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00029524 File Offset: 0x00027724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Type()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Type_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00004691 File Offset: 0x00002891
		public RegexNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00029560 File Offset: 0x00027760
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0000469A File Offset: 0x0000289A
		public unsafe int _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00029588 File Offset: 0x00027788
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000046B5 File Offset: 0x000028B5
		public unsafe List<RegexNode> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000295B8 File Offset: 0x000277B8
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000046D4 File Offset: 0x000028D4
		public unsafe string _str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000295E0 File Offset: 0x000277E0
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000046F3 File Offset: 0x000028F3
		public unsafe char _ch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__ch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__ch)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00029608 File Offset: 0x00027808
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x0000470E File Offset: 0x0000290E
		public unsafe int _m
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__m);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__m)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00029630 File Offset: 0x00027830
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00004729 File Offset: 0x00002929
		public unsafe int _n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__n);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__n)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00029658 File Offset: 0x00027858
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00004744 File Offset: 0x00002944
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00029680 File Offset: 0x00027880
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0000475F File Offset: 0x0000295F
		public unsafe RegexNode _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr__str;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr__ch;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr__m;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr__n;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_Reduce_Internal_RegexNode_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_ChildCount_Internal_Int32_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Type_Internal_Int32_0;
	}
}
