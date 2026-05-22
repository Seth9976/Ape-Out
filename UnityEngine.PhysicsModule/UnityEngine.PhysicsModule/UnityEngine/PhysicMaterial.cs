using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class PhysicMaterial : Object
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00004998 File Offset: 0x00002B98
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicMaterial()
		{
			Il2CppClassPointerStore<PhysicMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "PhysicMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicMaterial>.NativeClassPtr);
			PhysicMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicMaterial>.NativeClassPtr, 100663304);
			PhysicMaterial.NativeMethodInfoPtr_Internal_CreateDynamicsMaterial_Private_Static_Void_PhysicMaterial_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicMaterial>.NativeClassPtr, 100663305);
			PhysicMaterial.get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bouncinessDelegate>("UnityEngine.PhysicMaterial::get_bounciness");
			PhysicMaterial.set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bouncinessDelegate>("UnityEngine.PhysicMaterial::set_bounciness");
			PhysicMaterial.get_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::get_dynamicFriction");
			PhysicMaterial.set_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::set_dynamicFriction");
			PhysicMaterial.get_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_staticFrictionDelegate>("UnityEngine.PhysicMaterial::get_staticFriction");
			PhysicMaterial.set_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_staticFrictionDelegate>("UnityEngine.PhysicMaterial::set_staticFriction");
			PhysicMaterial.get_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_frictionCombineDelegate>("UnityEngine.PhysicMaterial::get_frictionCombine");
			PhysicMaterial.set_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_frictionCombineDelegate>("UnityEngine.PhysicMaterial::set_frictionCombine");
			PhysicMaterial.get_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bounceCombineDelegate>("UnityEngine.PhysicMaterial::get_bounceCombine");
			PhysicMaterial.set_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bounceCombineDelegate>("UnityEngine.PhysicMaterial::set_bounceCombine");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004A88 File Offset: 0x00002C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513516, XrefRangeEnd = 513525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004AC4 File Offset: 0x00002CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513525, XrefRangeEnd = 513529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicMaterial.NativeMethodInfoPtr_Internal_CreateDynamicsMaterial_Private_Static_Void_PhysicMaterial_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002204 File Offset: 0x00000404
		public PhysicMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000220D File Offset: 0x0000040D
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000221F File Offset: 0x0000041F
		public float bounciness
		{
			get
			{
				return PhysicMaterial.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002232 File Offset: 0x00000432
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002244 File Offset: 0x00000444
		public float dynamicFriction
		{
			get
			{
				return PhysicMaterial.get_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002257 File Offset: 0x00000457
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002269 File Offset: 0x00000469
		public float staticFriction
		{
			get
			{
				return PhysicMaterial.get_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000228E File Offset: 0x0000048E
		public PhysicMaterialCombine frictionCombine
		{
			get
			{
				return PhysicMaterial.get_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000022A1 File Offset: 0x000004A1
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022B3 File Offset: 0x000004B3
		public PhysicMaterialCombine bounceCombine
		{
			get
			{
				return PhysicMaterial.get_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004B0C File Offset: 0x00002D0C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022C6 File Offset: 0x000004C6
		public float bouncyness
		{
			get
			{
				return this.bounciness;
			}
			set
			{
				this.bounciness = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00004B24 File Offset: 0x00002D24
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000022D1 File Offset: 0x000004D1
		public Vector3 frictionDirection2
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004B3C File Offset: 0x00002D3C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000022D4 File Offset: 0x000004D4
		public float dynamicFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004B54 File Offset: 0x00002D54
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000022D7 File Offset: 0x000004D7
		public float staticFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004B6C File Offset: 0x00002D6C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000022DA File Offset: 0x000004DA
		public Vector3 frictionDirection
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateDynamicsMaterial_Private_Static_Void_PhysicMaterial_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly PhysicMaterial.get_bouncinessDelegate get_bouncinessDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly PhysicMaterial.set_bouncinessDelegate set_bouncinessDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly PhysicMaterial.get_dynamicFrictionDelegate get_dynamicFrictionDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly PhysicMaterial.set_dynamicFrictionDelegate set_dynamicFrictionDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly PhysicMaterial.get_staticFrictionDelegate get_staticFrictionDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly PhysicMaterial.set_staticFrictionDelegate set_staticFrictionDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly PhysicMaterial.get_frictionCombineDelegate get_frictionCombineDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly PhysicMaterial.set_frictionCombineDelegate set_frictionCombineDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly PhysicMaterial.get_bounceCombineDelegate get_bounceCombineDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly PhysicMaterial.set_bounceCombineDelegate set_bounceCombineDelegateField;

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000376 RID: 886
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000378 RID: 888
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600037A RID: 890
		private delegate float get_dynamicFrictionDelegate(IntPtr @this);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600037C RID: 892
		private delegate void set_dynamicFrictionDelegate(IntPtr @this, float value);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600037E RID: 894
		private delegate float get_staticFrictionDelegate(IntPtr @this);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000380 RID: 896
		private delegate void set_staticFrictionDelegate(IntPtr @this, float value);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000382 RID: 898
		private delegate PhysicMaterialCombine get_frictionCombineDelegate(IntPtr @this);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000384 RID: 900
		private delegate void set_frictionCombineDelegate(IntPtr @this, PhysicMaterialCombine value);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000386 RID: 902
		private delegate PhysicMaterialCombine get_bounceCombineDelegate(IntPtr @this);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000388 RID: 904
		private delegate void set_bounceCombineDelegate(IntPtr @this, PhysicMaterialCombine value);
	}
}
