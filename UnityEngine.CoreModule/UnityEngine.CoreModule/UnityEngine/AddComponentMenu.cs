using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C5 RID: 197
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x0004A654 File Offset: 0x00048854
		// Note: this type is marked as 'beforefieldinit'.
		static AddComponentMenu()
		{
			Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AddComponentMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
			AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_AddComponentMenu");
			AddComponentMenu.NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_Ordering");
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100664819);
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100664820);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0004A6D4 File Offset: 0x000488D4
		[CallerCount(0)]
		public unsafe AddComponentMenu(string menuName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0004A720 File Offset: 0x00048920
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName, int order)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0000A7F7 File Offset: 0x000089F7
		public AddComponentMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0004A77C File Offset: 0x0004897C
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0000A800 File Offset: 0x00008A00
		public unsafe string m_AddComponentMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0004A7A4 File Offset: 0x000489A4
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x0000A81F File Offset: 0x00008A1F
		public unsafe int m_Ordering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x0004A7CC File Offset: 0x000489CC
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0004A7E4 File Offset: 0x000489E4
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_m_AddComponentMenu;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr_m_Ordering;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
