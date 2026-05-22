using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class Gyroscope
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00003C5C File Offset: 0x00001E5C
		public static Vector3 rotationRate_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRate_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003C74 File Offset: 0x00001E74
		public static Vector3 rotationRateUnbiased_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRateUnbiased_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003C8C File Offset: 0x00001E8C
		public static Vector3 gravity_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.gravity_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public static Vector3 userAcceleration_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.userAcceleration_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003CBC File Offset: 0x00001EBC
		public static Quaternion attitude_Internal(int idx)
		{
			Quaternion quaternion;
			Gyroscope.attitude_Internal_Injected(idx, out quaternion);
			return quaternion;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000022B8 File Offset: 0x000004B8
		public static bool getEnabled_Internal(int idx)
		{
			return Gyroscope.getEnabled_InternalDelegateField(idx);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000022C5 File Offset: 0x000004C5
		public static void setEnabled_Internal(int idx, bool enabled)
		{
			Gyroscope.setEnabled_InternalDelegateField(idx, enabled);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022D3 File Offset: 0x000004D3
		public static float getUpdateInterval_Internal(int idx)
		{
			return Gyroscope.getUpdateInterval_InternalDelegateField(idx);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000022E0 File Offset: 0x000004E0
		public static void setUpdateInterval_Internal(int idx, float interval)
		{
			Gyroscope.setUpdateInterval_InternalDelegateField(idx, interval);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000022EE File Offset: 0x000004EE
		public Vector3 rotationRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000022FB File Offset: 0x000004FB
		public Vector3 rotationRateUnbiased
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002308 File Offset: 0x00000508
		public Vector3 gravity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002315 File Offset: 0x00000515
		public Vector3 userAcceleration
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002322 File Offset: 0x00000522
		public Quaternion attitude
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000232F File Offset: 0x0000052F
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000233C File Offset: 0x0000053C
		public bool enabled
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002349 File Offset: 0x00000549
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002356 File Offset: 0x00000556
		public float updateInterval
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002363 File Offset: 0x00000563
		public static void rotationRate_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRate_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002371 File Offset: 0x00000571
		public static void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRateUnbiased_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000237F File Offset: 0x0000057F
		public static void gravity_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.gravity_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000238D File Offset: 0x0000058D
		public static void userAcceleration_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.userAcceleration_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000239B File Offset: 0x0000059B
		public static void attitude_Internal_Injected(int idx, out Quaternion ret)
		{
			Gyroscope.attitude_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x04000088 RID: 136
		private static readonly Gyroscope.getEnabled_InternalDelegate getEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getEnabled_InternalDelegate>("UnityEngine.Gyroscope::getEnabled_Internal");

		// Token: 0x04000089 RID: 137
		private static readonly Gyroscope.setEnabled_InternalDelegate setEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setEnabled_InternalDelegate>("UnityEngine.Gyroscope::setEnabled_Internal");

		// Token: 0x0400008A RID: 138
		private static readonly Gyroscope.getUpdateInterval_InternalDelegate getUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::getUpdateInterval_Internal");

		// Token: 0x0400008B RID: 139
		private static readonly Gyroscope.setUpdateInterval_InternalDelegate setUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::setUpdateInterval_Internal");

		// Token: 0x0400008C RID: 140
		private static readonly Gyroscope.rotationRate_Internal_InjectedDelegate rotationRate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRate_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRate_Internal_Injected");

		// Token: 0x0400008D RID: 141
		private static readonly Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate rotationRateUnbiased_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRateUnbiased_Internal_Injected");

		// Token: 0x0400008E RID: 142
		private static readonly Gyroscope.gravity_Internal_InjectedDelegate gravity_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.gravity_Internal_InjectedDelegate>("UnityEngine.Gyroscope::gravity_Internal_Injected");

		// Token: 0x0400008F RID: 143
		private static readonly Gyroscope.userAcceleration_Internal_InjectedDelegate userAcceleration_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.userAcceleration_Internal_InjectedDelegate>("UnityEngine.Gyroscope::userAcceleration_Internal_Injected");

		// Token: 0x04000090 RID: 144
		private static readonly Gyroscope.attitude_Internal_InjectedDelegate attitude_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.attitude_Internal_InjectedDelegate>("UnityEngine.Gyroscope::attitude_Internal_Injected");

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060000EA RID: 234
		private delegate bool getEnabled_InternalDelegate(int idx);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060000EC RID: 236
		private delegate void setEnabled_InternalDelegate(int idx, bool enabled);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000EE RID: 238
		private delegate float getUpdateInterval_InternalDelegate(int idx);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060000F0 RID: 240
		private delegate void setUpdateInterval_InternalDelegate(int idx, float interval);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060000F2 RID: 242
		private delegate void rotationRate_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060000F4 RID: 244
		private delegate void rotationRateUnbiased_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060000F6 RID: 246
		private delegate void gravity_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060000F8 RID: 248
		private delegate void userAcceleration_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060000FA RID: 250
		private delegate void attitude_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);
	}
}
