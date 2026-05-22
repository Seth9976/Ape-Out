using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C7 RID: 199
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x0004AA34 File Offset: 0x00048C34
		// Note: this type is marked as 'beforefieldinit'.
		static ContextMenu()
		{
			Il2CppClassPointerStore<ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ContextMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr);
			ContextMenu.NativeFieldInfoPtr_menuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "menuItem");
			ContextMenu.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "validate");
			ContextMenu.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "priority");
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100664825);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100664826);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100664827);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0004AADC File Offset: 0x00048CDC
		[CallerCount(0)]
		public unsafe ContextMenu(string itemName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0004AB28 File Offset: 0x00048D28
		[CallerCount(0)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0004AB84 File Offset: 0x00048D84
		[CallerCount(0)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction, int priority)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		public ContextMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x0004ABEC File Offset: 0x00048DEC
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x0000A8BD File Offset: 0x00008ABD
		public unsafe string menuItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x0004AC14 File Offset: 0x00048E14
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x0000A8DC File Offset: 0x00008ADC
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x0004AC3C File Offset: 0x00048E3C
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x0000A8F7 File Offset: 0x00008AF7
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_menuItem;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0;
	}
}
