using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000108 RID: 264
	public sealed class Position : ValueType
	{
		// Token: 0x060015EF RID: 5615 RVA: 0x000707A0 File Offset: 0x0006E9A0
		// Note: this type is marked as 'beforefieldinit'.
		static Position()
		{
			Il2CppClassPointerStore<Position>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Position");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Position>.NativeClassPtr);
			Position.NativeFieldInfoPtr_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "symbol");
			Position.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "particle");
			Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Position>.NativeClassPtr, 100666608);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0007080C File Offset: 0x0006EA0C
		[CallerCount(0)]
		public unsafe Position(int symbol, Object particle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00009CFA File Offset: 0x00007EFA
		public Position(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00009D03 File Offset: 0x00007F03
		public Position()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0007086C File Offset: 0x0006EA6C
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00009D15 File Offset: 0x00007F15
		public unsafe int symbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol)) = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00070894 File Offset: 0x0006EA94
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00009D30 File Offset: 0x00007F30
		public unsafe Object particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_symbol;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;
	}
}
