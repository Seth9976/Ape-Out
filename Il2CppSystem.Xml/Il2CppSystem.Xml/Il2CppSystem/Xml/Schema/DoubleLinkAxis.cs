using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMS.Internal.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F7 RID: 247
	public class DoubleLinkAxis : Axis
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x0006B8AC File Offset: 0x00069AAC
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleLinkAxis()
		{
			Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DoubleLinkAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr);
			DoubleLinkAxis.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, "next");
			DoubleLinkAxis.NativeMethodInfoPtr_get_Next_Internal_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666455);
			DoubleLinkAxis.NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666456);
			DoubleLinkAxis.NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666457);
			DoubleLinkAxis.NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666458);
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0006B940 File Offset: 0x00069B40
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0006B980 File Offset: 0x00069B80
		public unsafe Axis Next
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_get_Next_Internal_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0006B9C4 File Offset: 0x00069BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407959, XrefRangeEnd = 407960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputaxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0006BA24 File Offset: 0x00069C24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 407967, RefRangeEnd = 407972, XrefRangeStart = 407960, XrefRangeEnd = 407967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DoubleLinkAxis ConvertTree(Axis axis)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00009377 File Offset: 0x00007577
		public DoubleLinkAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0006BA68 File Offset: 0x00069C68
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00009380 File Offset: 0x00007580
		public unsafe Axis next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleLinkAxis.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Axis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleLinkAxis.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_Axis_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0;
	}
}
