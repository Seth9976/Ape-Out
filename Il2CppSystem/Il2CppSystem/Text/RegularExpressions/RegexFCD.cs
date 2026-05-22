using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000054 RID: 84
	public sealed class RegexFCD : Object
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x000250B4 File Offset: 0x000232B4
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFCD()
		{
			Il2CppClassPointerStore<RegexFCD>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFCD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr);
			RegexFCD.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intStack");
			RegexFCD.NativeFieldInfoPtr__intDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intDepth");
			RegexFCD.NativeFieldInfoPtr__fcStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcStack");
			RegexFCD.NativeFieldInfoPtr__fcDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcDepth");
			RegexFCD.NativeFieldInfoPtr__skipAllChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipAllChildren");
			RegexFCD.NativeFieldInfoPtr__skipchild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipchild");
			RegexFCD.NativeFieldInfoPtr__failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_failed");
			RegexFCD.NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664127);
			RegexFCD.NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664128);
			RegexFCD.NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664129);
			RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664130);
			RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664131);
			RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664132);
			RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664133);
			RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664134);
			RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664135);
			RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664136);
			RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664137);
			RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664138);
			RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664139);
			RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664140);
			RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664141);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002529C File Offset: 0x0002349C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370440, RefRangeEnd = 370441, XrefRangeStart = 370415, XrefRangeEnd = 370440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexPrefix FirstChars(RegexTree t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000252E0 File Offset: 0x000234E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370455, RefRangeEnd = 370456, XrefRangeStart = 370441, XrefRangeEnd = 370455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexPrefix Prefix(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00025324 File Offset: 0x00023524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370469, RefRangeEnd = 370470, XrefRangeStart = 370456, XrefRangeEnd = 370469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Anchors(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00025368 File Offset: 0x00023568
		[CallerCount(0)]
		public unsafe static int AnchorFromType(int type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000253A8 File Offset: 0x000235A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370470, XrefRangeEnd = 370476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFCD()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000253E4 File Offset: 0x000235E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370476, XrefRangeEnd = 370480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInt(int I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00025424 File Offset: 0x00023624
		[CallerCount(0)]
		public unsafe bool IntIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00025460 File Offset: 0x00023660
		[CallerCount(0)]
		public unsafe int PopInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002549C File Offset: 0x0002369C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370485, RefRangeEnd = 370486, XrefRangeStart = 370480, XrefRangeEnd = 370485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushFC(RegexFC fc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000254E0 File Offset: 0x000236E0
		[CallerCount(0)]
		public unsafe bool FCIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002551C File Offset: 0x0002371C
		[CallerCount(0)]
		public unsafe RegexFC PopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002555C File Offset: 0x0002375C
		[CallerCount(0)]
		public unsafe RegexFC TopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002559C File Offset: 0x0002379C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370498, RefRangeEnd = 370499, XrefRangeStart = 370486, XrefRangeEnd = 370498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000255EC File Offset: 0x000237EC
		[CallerCount(0)]
		public unsafe void SkipChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00025620 File Offset: 0x00023820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370529, RefRangeEnd = 370532, XrefRangeStart = 370499, XrefRangeEnd = 370529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref NodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CurIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003F89 File Offset: 0x00002189
		public RegexFCD(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00025680 File Offset: 0x00023880
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003F92 File Offset: 0x00002192
		public unsafe Il2CppStructArray<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000256B0 File Offset: 0x000238B0
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00003FB1 File Offset: 0x000021B1
		public unsafe int _intDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intDepth)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000256D8 File Offset: 0x000238D8
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00003FCC File Offset: 0x000021CC
		public unsafe Il2CppReferenceArray<RegexFC> _fcStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RegexFC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00025708 File Offset: 0x00023908
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00003FEB File Offset: 0x000021EB
		public unsafe int _fcDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcDepth)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00025730 File Offset: 0x00023930
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004006 File Offset: 0x00002206
		public unsafe bool _skipAllChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00025758 File Offset: 0x00023958
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004021 File Offset: 0x00002221
		public unsafe bool _skipchild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00025780 File Offset: 0x00023980
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0000403C File Offset: 0x0000223C
		public unsafe bool _failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed)) = value;
			}
		}

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr__intDepth;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr__fcStack;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr__fcDepth;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr__skipAllChildren;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr__skipchild;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr__failed;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_PushInt_Private_Void_Int32_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_PopInt_Private_Int32_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_PopFC_Private_RegexFC_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_TopFC_Private_RegexFC_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_SkipChild_Private_Void_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0;
	}
}
