using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000421 RID: 1057
	[Serializable]
	public class StateMachineAttribute : Attribute
	{
		// Token: 0x060042F6 RID: 17142 RVA: 0x00136C38 File Offset: 0x00134E38
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineAttribute()
		{
			Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr);
			StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, "<StateMachineType>k__BackingField");
			StateMachineAttribute.NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100673092);
			StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100673093);
		}

		// Token: 0x17001124 RID: 4388
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x00136CA4 File Offset: 0x00134EA4
		public unsafe Type StateMachineType
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00136CE8 File Offset: 0x00134EE8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x0001956F File Offset: 0x0001776F
		public StateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x00136D34 File Offset: 0x00134F34
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00019578 File Offset: 0x00017778
		public unsafe Type _StateMachineType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003684 RID: 13956
		private static readonly IntPtr NativeFieldInfoPtr__StateMachineType_k__BackingField;

		// Token: 0x04003685 RID: 13957
		private static readonly IntPtr NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0;

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
