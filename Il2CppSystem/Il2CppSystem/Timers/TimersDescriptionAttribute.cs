using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Timers
{
	// Token: 0x02000049 RID: 73
	public class TimersDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00021068 File Offset: 0x0001F268
		// Note: this type is marked as 'beforefieldinit'.
		static TimersDescriptionAttribute()
		{
			Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Timers", "TimersDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr);
			TimersDescriptionAttribute.NativeFieldInfoPtr_replaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr, "replaced");
			TimersDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr, 100664010);
			TimersDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr, 100664011);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000210D4 File Offset: 0x0001F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369390, XrefRangeEnd = 369393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimersDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimersDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimersDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00021120 File Offset: 0x0001F320
		public unsafe override string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimersDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003775 File Offset: 0x00001975
		public TimersDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00021164 File Offset: 0x0001F364
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000377E File Offset: 0x0000197E
		public unsafe bool replaced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimersDescriptionAttribute.NativeFieldInfoPtr_replaced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimersDescriptionAttribute.NativeFieldInfoPtr_replaced)) = value;
			}
		}

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_replaced;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
	}
}
