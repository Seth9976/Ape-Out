using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000012 RID: 18
	public sealed class JobProducerTypeAttribute : Attribute
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000163E8 File Offset: 0x000145E8
		// Note: this type is marked as 'beforefieldinit'.
		static JobProducerTypeAttribute()
		{
			Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobProducerTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr);
			JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, "<ProducerType>k__BackingField");
			JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, 100663328);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00016440 File Offset: 0x00014640
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobProducerTypeAttribute(Type producerType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(producerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024BC File Offset: 0x000006BC
		public JobProducerTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0001648C File Offset: 0x0001468C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe Type _ProducerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000024E4 File Offset: 0x000006E4
		public Type ProducerType
		{
			get
			{
				return this._ProducerType_k__BackingField;
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__ProducerType_k__BackingField;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
