using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000043 RID: 67
	[StructLayout(2)]
	public struct SortingLayer
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x000194A0 File Offset: 0x000176A0
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayer()
		{
			Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SortingLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
			SortingLayer.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, "m_Id");
			SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663413);
			SortingLayer.NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663414);
			SortingLayer.GetSortingLayerIDsInternalDelegateField = IL2CPP.ResolveICall<SortingLayer.GetSortingLayerIDsInternalDelegate>("UnityEngine.SortingLayer::GetSortingLayerIDsInternal");
			SortingLayer.GetLayerValueFromNameDelegateField = IL2CPP.ResolveICall<SortingLayer.GetLayerValueFromNameDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName");
			SortingLayer.IDToNameDelegateField = IL2CPP.ResolveICall<SortingLayer.IDToNameDelegate>("UnityEngine.SortingLayer::IDToName");
			SortingLayer.IsValidDelegateField = IL2CPP.ResolveICall<SortingLayer.IsValidDelegate>("UnityEngine.SortingLayer::IsValid");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00019548 File Offset: 0x00017748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485958, XrefRangeEnd = 485962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerValueFromID(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00019588 File Offset: 0x00017788
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 485966, RefRangeEnd = 485970, XrefRangeStart = 485962, XrefRangeEnd = 485966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NameToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000031D8 File Offset: 0x000013D8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000195CC File Offset: 0x000177CC
		public int id
		{
			get
			{
				return this.m_Id;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000195E4 File Offset: 0x000177E4
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00019604 File Offset: 0x00017804
		public int value
		{
			get
			{
				return SortingLayer.GetLayerValueFromID(this.m_Id);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000031EA File Offset: 0x000013EA
		public static Il2CppStructArray<SortingLayer> layers
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00019624 File Offset: 0x00017824
		public static Il2CppStructArray<int> GetSortingLayerIDsInternal()
		{
			IntPtr intPtr = SortingLayer.GetSortingLayerIDsInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000031F7 File Offset: 0x000013F7
		public static int GetLayerValueFromName(string name)
		{
			return SortingLayer.GetLayerValueFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001964C File Offset: 0x0001784C
		public static string IDToName(int id)
		{
			IntPtr intPtr = SortingLayer.IDToNameDelegateField(id);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00003209 File Offset: 0x00001409
		public static bool IsValid(int id)
		{
			return SortingLayer.IsValidDelegateField(id);
		}

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0;

		// Token: 0x0400018A RID: 394
		[FieldOffset(0)]
		public int m_Id;

		// Token: 0x0400018B RID: 395
		private static readonly SortingLayer.GetSortingLayerIDsInternalDelegate GetSortingLayerIDsInternalDelegateField;

		// Token: 0x0400018C RID: 396
		private static readonly SortingLayer.GetLayerValueFromNameDelegate GetLayerValueFromNameDelegateField;

		// Token: 0x0400018D RID: 397
		private static readonly SortingLayer.IDToNameDelegate IDToNameDelegateField;

		// Token: 0x0400018E RID: 398
		private static readonly SortingLayer.IsValidDelegate IsValidDelegateField;

		// Token: 0x02000335 RID: 821
		// (Invoke) Token: 0x06002483 RID: 9347
		private delegate IntPtr GetSortingLayerIDsInternalDelegate();

		// Token: 0x02000336 RID: 822
		// (Invoke) Token: 0x06002485 RID: 9349
		private delegate int GetLayerValueFromNameDelegate(IntPtr name);

		// Token: 0x02000337 RID: 823
		// (Invoke) Token: 0x06002487 RID: 9351
		private delegate IntPtr IDToNameDelegate(int id);

		// Token: 0x02000338 RID: 824
		// (Invoke) Token: 0x06002489 RID: 9353
		private delegate bool IsValidDelegate(int id);
	}
}
