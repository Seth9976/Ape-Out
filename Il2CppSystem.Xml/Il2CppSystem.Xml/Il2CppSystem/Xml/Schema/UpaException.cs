using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000106 RID: 262
	public class UpaException : Exception
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x0006FF98 File Offset: 0x0006E198
		// Note: this type is marked as 'beforefieldinit'.
		static UpaException()
		{
			Il2CppClassPointerStore<UpaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "UpaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpaException>.NativeClassPtr);
			UpaException.NativeFieldInfoPtr_particle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle1");
			UpaException.NativeFieldInfoPtr_particle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle2");
			UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100666593);
			UpaException.NativeMethodInfoPtr_get_Particle1_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100666594);
			UpaException.NativeMethodInfoPtr_get_Particle2_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100666595);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0007002C File Offset: 0x0006E22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409202, XrefRangeEnd = 409206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpaException(Object particle1, Object particle2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x0007008C File Offset: 0x0006E28C
		public unsafe Object Particle1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr_get_Particle1_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x000700CC File Offset: 0x0006E2CC
		public unsafe Object Particle2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr_get_Particle2_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00009BF8 File Offset: 0x00007DF8
		public UpaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0007010C File Offset: 0x0006E30C
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00009C01 File Offset: 0x00007E01
		public unsafe Object particle1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0007013C File Offset: 0x0006E33C
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00009C20 File Offset: 0x00007E20
		public unsafe Object particle2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeFieldInfoPtr_particle1;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeFieldInfoPtr_particle2;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle1_Public_get_Object_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle2_Public_get_Object_0;
	}
}
