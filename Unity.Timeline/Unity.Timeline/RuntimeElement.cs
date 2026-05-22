using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000021 RID: 33
	public class RuntimeElement : Object
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0001211C File Offset: 0x0001031C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeElement()
		{
			Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "RuntimeElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr);
			RuntimeElement.NativeFieldInfoPtr__intervalBit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, "<intervalBit>k__BackingField");
			RuntimeElement.NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663893);
			RuntimeElement.NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663894);
			RuntimeElement.NativeMethodInfoPtr_get_intervalBit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663895);
			RuntimeElement.NativeMethodInfoPtr_set_intervalBit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663896);
			RuntimeElement.NativeMethodInfoPtr_set_enable_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663897);
			RuntimeElement.NativeMethodInfoPtr_EvaluateAt_Public_Abstract_Virtual_New_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663898);
			RuntimeElement.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663899);
			RuntimeElement.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr, 100663900);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00012200 File Offset: 0x00010400
		public unsafe virtual long intervalStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeElement.NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00012248 File Offset: 0x00010448
		public unsafe virtual long intervalEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeElement.NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00012290 File Offset: 0x00010490
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000122CC File Offset: 0x000104CC
		public unsafe int intervalBit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeElement.NativeMethodInfoPtr_get_intervalBit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeElement.NativeMethodInfoPtr_set_intervalBit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0001230C File Offset: 0x0001050C
		public unsafe virtual bool enable
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeElement.NativeMethodInfoPtr_set_enable_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00012358 File Offset: 0x00010558
		[CallerCount(0)]
		public unsafe virtual void EvaluateAt(double localTime, FrameData frameData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeElement.NativeMethodInfoPtr_EvaluateAt_Public_Abstract_Virtual_New_Void_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000123B0 File Offset: 0x000105B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeElement.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000123EC File Offset: 0x000105EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeElement.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003138 File Offset: 0x00001338
		public RuntimeElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00012428 File Offset: 0x00010628
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003141 File Offset: 0x00001341
		public unsafe int _intervalBit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeElement.NativeFieldInfoPtr__intervalBit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeElement.NativeFieldInfoPtr__intervalBit_k__BackingField)) = value;
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr__intervalBit_k__BackingField;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalBit_Public_get_Int32_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_set_intervalBit_Public_set_Void_Int32_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Abstract_Virtual_New_Void_Double_FrameData_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
